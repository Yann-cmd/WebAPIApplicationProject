# Projet WebAPIApplicationProject

# 1. Projet

WebAPIApplicationProject est un projet d'API WEB en c# .NET version ```8.0```. 

Il permet d'exposer un CRUD complet sur la nourriture végétale comme les fruits et les légumes. Le projet comprends également une interface FRONT. 

Le but principal de cette interface est de permettre aux utilisateurs d'accéder à une liste de fruits et légumes et de pouvoir savoir lequels parmi les liste sont des fruits/légumes de saison et leur provenance. Cela peut être intérressant pour les personnes qui cherchent à se nourrir avec des produits locaux et de saisons. 

L'interface web propose également un espace de connexion et de création de compte.

# 2. Architecture

L'architecture du projet se décompose en plusieurs dossiers : 

__WebAPIApplicationProject__ :

```
WebAPIApplicationProject
├── Properties           # contient le fichier de propriété lauchSettings.json
├── wwwroot              # contient tous les fichiers/dossiers web
├── Controllers          # contient les controllers du projet
├── Models               # contient les models du projet
├── appSettings.json
├── program.cs           # fichier c# de lancement du projet
```

# 3. Installation
Pour pouvoir utilisé l'application, il faut d'abord y installer tous les éléments nécessaire à son bon fonctionnement. Pour ce faire, la première étape est de :

- Télécharger le projet en cliquant sur ```Download ZIP``` dans la section _Code_ en vert.
- Ou importer le projet via git bash par example via la commande ```https://github.com/Yann-cmd/WebAPIApplicationProject.git```

# 4. Get started
Une fois toutes ces étapes prises en compte, vous pouvez lancer le projet.

Il n'y a pas de compte enregistré par défaut, l'utilisateur est libre de s'en créer un directement depuis l'interface web.

Dans votre IDE, rendez-vous en haut de votre écran et cliquez sur l'icone d'une flèche verte __Exécuter__. 

Cela va exécuter le projet et lancer directement le FRONT et BACK en même temps. Par défaut, le swagger s'ouvrira automatiquement à cet URL : ```https://localhost:7168/swagger/index.html```.

Le front tourne sur le port : __7168__

Le back tourne sur le port : __5031__ (nécessaire si vus voulez faire des tests de l'API depuis _Postman_ par exemple).
