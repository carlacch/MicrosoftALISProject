# MicrosoftALISProject
### Contexte
Le Locked-In Syndrome (LIS) est une maladie neurologique rare qui survient généralement à la suite d'un >

Ce projet, initié par Microsoft en collaboration avec l’association ALIS, a pour objectif de faciliter l>

Voici notre interface ergonomique pour la Communication Alternative Augmentée afin d'aider les personnes>

### Installation

L'application nécessite Visual Studio.
Afin de pouvoir utiliser l'application, python et plusieurs librairies sont nécessaires.
Les commandes suivantes permettent l'insatallation de ces librairies:
```
pip install "transformers==2.5.1"
pip install torch==1.7.1+cpu torchvision==0.8.2+cpu torchaudio===0.7.2 -f https://download.pytorch.org/w>
pip install spacy_lefff
pip install spacy
python -m spacy download fr_core_news_sm
```

Définir dans Visual Studio des variables d'environnement pour la reconnaissance et synthèse vocale. Pour cela, aller dans Projet > Propriété > Debugger. Ajouter:
- speech_key : `Clé Microsoft`
- service_region : `francecentral` (valeur utilisé dans ce cas)

### Application

Notre interface WindowsForm se lance à partir du fichier [WindowsFormsApp1.sln](WindowsFormsApp1/Windows>
Une fois lancée, plusieurs page sont disponibles :
![aLIS_demo](WindowsFormsApp1/Images/demo/aLIS_demo.gif)

Afin que cela soit clair et structuré, chaque page est créée à l'aide d'un UserControl.

L'application inclu une partie reconnaisance vocale qui permet de détecter lorsqu'un intrelocuteur s'adr>

La partie synthèse vocale va rendre la parole à l'utilisateur en lui permetant d'exprimer ses idées à l'>

Pour toute la partie prédiction, nous utilisons l'API que nous avons développé, disponible [ici](Windows>

### Reconnaissance et synthèse vocale

La synthèse et la reconnaissance vocale sont implémentées via le module `Microsoft.CognitiveServices.Speech`. 
* La **synthèse vocale** est définie dans les documents `Form1.cs` et `UserControlStandard.cs` par la méthode **Speak**.

    ![synthèse_vocale_function](WindowsFormsApp1/Images/demo/voice_synthesis.png)
* La **reconnaissance vocale** est définie dans `UserControlReact.cs` par la méthode **GetSpeech**.

    ![getSPeech_function](WindowsFormsApp1/Images/demo/getSpeech_function.png)

  L'execution de cette méthode se fait sous deux formes:
  1. Automatique - Ce type de reconnaissance est lancé dès le lancement de l'application et écoute de façon passive l'utilisateur. Si il prononce, le nom de la personne atteinte du LIS alors le système s'active.
  
  2. Manuel - L'utilisateur lance la reconnaissance en cliquant sur le bouton **Ecouter**

  Losrque la reconnaissance est activée, le système renvoie toutes les phrases dites sur l'onglet React (`UserControlReact.cs`) jusqu'à la présence d'un mot d'arrêt.

  Ces mots clés sont présent dans un fichier de [configFile](WindowsFormsApp1/Config/configFile). Le nom de la personne est représentée par la variable **USERNAME** et Les mots d'arrêts par **STOP_WORDS**.

  Pour définir des mots d'arrêts, il suffit de les écrire séparés par `/`.

  Si l'utilisateur lance la reconnaissance de façon manuelle alors la reconnaissance automatique s'arrête. Elle reprend dès qu'un mot d'arrêt est prononcé.

### Prédiction et API

### Améliorations possible

- [ ] Affiner le modèle de prédiction
- [ ] Meilleur post tagger pour les thèmes
- [ ] Développement de sboutons d'édition de thèmes
- [ ] Implémentation des fonctionnalités Lieux, Bibliothèque, Contact et Paramètres
- [ ] Obtention d'une clé OpenAI pour suggérer de sréponses entières
- [ ] Construction de phrases automatiques à partir de mots clés / Système d'auto-correction
- [ ] Réécriture du modèle de prédiction en C# pour plus de rapidité

