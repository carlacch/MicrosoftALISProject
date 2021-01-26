import requests
import json

#Demande d'un résultat à travers l'API
url = 'http://localhost:5001/api/predictNext'

phrase = []
phrase.append(["J'ai besoin de "])
phrase.append(["Aller aux t"])
phrase.append(["Je vous "])
phrase.append(["J' "])
phrase.append([""])

j_data = json.dumps(phrase[3])
headers = {'content-type': 'text/plain', 'Accept-Charset': 'UTF-8'}
r = requests.post(url, data="besoin de ", headers=headers)
print(r, r.text)