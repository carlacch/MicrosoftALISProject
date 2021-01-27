# MicrosoftALISProject
### Contexte
Le Locked-In Syndrome (LIS) est une maladie neurologique rare qui survient généralement à la suite d'un AVC.  Les personnes atteintes se retrouvent pour la plupart tétraplégiques et muettes. Pour communiquer, des solutions existent mais sont très chronophages, demandant à l’utilisateur d’écrire caractère par caractère.  

Ce projet, initié par Microsoft en collaboration avec l’association ALIS, a pour objectif de faciliter la communication d’une personne LIS avec un interlocuteur physique grâce à de l’Intelligence Artificielle. Pour cela, une solution de type clavier prédictif a été imaginée. L’application réalisée vise à  détecter les phrases prononcées par l’interlocuteur et proposer différents thèmes ainsi que leurs mots associés afin de permettre à l’utilisateur de composer une phrase beaucoup plus rapidement que les solutions existantes actuellement.  

Voici notre interface ergonomique pour la Communication Alternative Augmentée afin d'aider les personnes atteintes du Locked In Syndrome.

### Installation

L'application nécessite Visual Studio.  
Afin de pouvoir utiliser l'application, python et plusieurs librairies sont nécessaires.  
Les commandes suivantes permettent l'insatallation de ces librairies: 
```
pip install "transformers==2.5.1"
pip install torch==1.7.1+cpu torchvision==0.8.2+cpu torchaudio===0.7.2 -f https://download.pytorch.org/whl/torch_stable.html
pip install spacy_lefff
pip install spacy
python -m spacy download fr_core_news_sm
```

### Application

Notre interface WindowsForm se lance à partir du fichier [WindowsFormsApp1.sln](WindowsFormsApp1/WindowsFormsApp1.sln).  
Une fois lancée, plusieurs page sont disponibles :  
![aLIS_demo](WindowsFormsApp1/Images/demo/aLIS_demo.gif)

Afin que cela soit clair et structuré, chaque page est créée à l'aide d'un UserControl.

L'application inclu une partie reconnaisance vocale qui permet de détecter lorsqu'un intrelocuteur s'adresse à l'utilisateur par un mot prédéfini, en général le nom de l'utilisateur. La configuration du nom est possible en modifiant l'username dans les [configurations](WindowsFormsApp1/Config/configFile). Le but étant que, dans le futur, cela se fasse directement dans les paramètres de l'application.

La partie synthèse vocale va rendre la parole à l'utilisateur en lui permetant d'exprimer ses idées à l'oral. C'est le bouton &nbsp;  ![vocal](WindowsFormsApp1/Images/speaking.png) &nbsp; qui permet cela. 

Pour toute la partie prédiction, nous utilisons l'API que nous avons développé, disponible [ici](WindowsFormsApp1\API).  

### Prédiction et API
