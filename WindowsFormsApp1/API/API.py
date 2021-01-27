from flask import Flask, request
import pickle
import torch
import transformers
from transformers.modeling_camembert import CamembertForMaskedLM
from transformers.tokenization_camembert import CamembertTokenizer
import json
import string
import spacy
from spacy_lefff import LefffLemmatizer, POSTagger;

nlp = spacy.load('fr_core_news_sm')
french_lemmatizer = LefffLemmatizer()
nlp.add_pipe(french_lemmatizer, name='lefff')

app = Flask(__name__)

#Ouverture du modèle
tokenizer = CamembertTokenizer.from_pretrained("camembert-base")

def fill_mask(masked_input, model, tokenizer, topk=5):
    # Adapted from https://github.com/pytorch/fairseq/blob/master/fairseq/models/roberta/hub_interface.py
    assert masked_input.count("<mask>") == 1
    input_ids = torch.tensor(tokenizer.encode(masked_input, add_special_tokens=True)).unsqueeze(0)  # Batch size 1
    logits = model(input_ids)[0]  # The last hidden-state is the first element of the output tuple
    masked_index = (input_ids.squeeze() == tokenizer.mask_token_id).nonzero().item()
    logits = logits[0, masked_index, :]
    prob = logits.softmax(dim=0)
    values, indices = prob.topk(k=topk, dim=0)
    topk_predicted_token_bpe = " ".join(
        [tokenizer.convert_ids_to_tokens(indices[i].item()) for i in range(len(indices))]
    )
    masked_token = tokenizer.mask_token
    topk_filled_outputs = []
    for index, predicted_token_bpe in enumerate(topk_predicted_token_bpe.split(" ")):
        predicted_token = predicted_token_bpe.replace("\u2581", " ")
        if " {0}".format(masked_token) in masked_input:
            topk_filled_outputs.append(
                (
                    masked_input.replace(" {0}".format(masked_token), predicted_token),
                    values[index].item(),
                    predicted_token,
                )
            )
        else:
            topk_filled_outputs.append(
                (masked_input.replace(masked_token, predicted_token), values[index].item(), predicted_token,)
            )
    return topk_filled_outputs


def nextWord(text, number_Of_Predictions):
  masked_input= text +" <mask>"
  predictions=[]
  for i in range(0,number_Of_Predictions):
    predictions.append(fill_mask(masked_input, model, tokenizer, number_Of_Predictions)[i][2])
  nb_pred = len(predictions)
  for i in range(nb_pred):
      predictions[i] = predictions[i][1:nb_pred-1]
  i = 0

  while i < nb_pred:
      predictions[i] = predictions[i].translate(str.maketrans('', '', string.punctuation))
      if predictions[i] == "":
          del predictions[i]
          nb_pred -= 1
      i+= 1
  return predictions

def currentWord(text):
    result = []
    print(text)
    if text == "":
        text = " "
    if text[len(text)-1] != " ":
        words = text.split(" ")
        writing = words[len(words)-1]
        predictions = nextWord(" ".join(words[:(len(words)-1)]), 50)
        for pred in predictions:
            if (pred.startswith(writing)):
                result.append(pred)
    else:
        return(nextWord(text, 50))
    return result;

#API
@app.route('/api/predictNext',methods=['POST'])
def predict():
    text_string = request.data.decode("utf-8")
    #Prédiction et retour
    prediction = currentWord(text_string)
    result = []
    for i in range(len(prediction)):
       result.append([prediction[i], nlp(prediction[i])[0].pos_])
    print("\n"+text_string)
    print(result)
    return json.dumps(result, ensure_ascii=False)

#Retour du résultat
if __name__ == '__main__':

    model = pickle.load(open('model.pickle', 'rb'))
    app.run(port=5001, debug=True)