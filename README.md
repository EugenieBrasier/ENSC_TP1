# TP 1 : Roll a Ball

### Objectif : 
L'objectif de de TP est de réaliser un mini jeu avec Unity (peu importe la version choisie) répondant aux critères suivants : 
1) Une bille est manipulable par un utilisateur grâce aux flèches directionelles du clavier
2) Cette bille collecte des objets sur le terrain
3) Lorsque cette bille a collecté tous les objets, la scène se termine avec un écran de fin

<p align="center">
  <img width="50%" src="ressources/final.gif" />
</p>

## Setup

1) Télécharger la dernière version de Unity si ce n'est pas déjà fait [ici](https://unity.com/fr/download)
2) Créer un projet Unity 3D

## Etape 1 : Créer le terrain et la bille

1) Créer le terrain en ajoutant à la scène une série de cubes que vous allez redimensionner. Pour cela, faire clic droit dans l'onglet "Hierarchy" puis "3D Objects" puis "Cube". Changer ensuite les valeurs de position et de scale dans l'"Inspector".
2) Créer un object vide dans la scène et le nommer "Field". Ajouter tous les éléments du terrain comme enfant de ce nouvel objet.
3) Créer la bille et la placer au centre du terrain.

[!NOTE]
Vous pouvez customiser vos objets en leur appliquant un matériau spécifique.
Pour cela, allez voir la [documentation]().

## Etape 2 : Créer les objets à collecter

Add Component > Physics > RigidBody
