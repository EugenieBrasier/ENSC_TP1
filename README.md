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

## Etape 1 : Créer le terrain

1) Créer le terrain en ajoutant à la scène une série de cubes que vous allez redimensionner. Pour cela, faire clic droit dans l'onglet "Hierarchy" puis "3D Objects" puis "Cube". Changer ensuite les valeurs de position et de scale dans l'"Inspector".
2) Créer un object vide dans la scène et le nommer "Field". Ajouter tous les éléments du terrain comme enfant de ce nouvel objet.

> [!NOTE]
> Vous pouvez customiser vos objets en leur appliquant un matériau spécifique.
> Pour cela, allez voir la [documentation](https://docs.unity3d.com/Manual/Materials.html).

## Etape 2 : Création de la bille (joueur)

1) Créer la bille (sphère 3D) et la placer au centre du terrain.
2) Ajouter un composant Rigidbody pour que celle-ci utilise le moteur physique. Nous pourrons ainsi lui appliquer des forces comme la gravité. Vous pouvez aller voir la [documentation](https://docs.unity3d.com/Manual/class-Rigidbody.html).
3) Créer un nouveau dossier "Scripts" dans votre projet.
4) A l'intérieur de ce dossier, ajouter un nouveau script de type "MonoBehaviour" nommé "DirectionalControls".
5) Ajouter ce script comme nouveau composant de la bille et double-cliquer dessus dans la partie projet pour pouvoir le modifier.
6) Dans la fonction `Start`, récupérer le composant Rigidbody en utilisant la fonction `GetComponent<Rigidbody>()`.
7) Dans la fonction `Update`, récupérer les touches directionnelles sur lesquelles l'utilisateur appuie et modifier le comportement de la bille en conséquence.

> [!NOTE]
> Vous pouvez savoir si l'utilisateur appuie sur une touche du clavier grâce à `Keyboard.current.<key>.isPressed`.
> Vous pouvez aller voir la documentation de [Keyboard](https://docs.unity3d.com/Packages/com.unity.inputsystem%401.13/api/UnityEngine.InputSystem.Keyboard.html?utm_source=chatgpt.com) et [KeyControl.IsPressed](https://docs.unity3d.com/Packages/com.unity.inputsystem%401.13/api/UnityEngine.InputSystem.Keyboard.html?utm_source=chatgpt.com).

Ensuite, on peut créer un Vector3 qui contient les mouvements Droite/Gauche (pour les x) et les mouvements Haut/Bas (pour les z). Ce vecteur représente le vecteur final des forces à appliquer sur la bille.

Pour finir, on peut utiliser la fonction AddForce() de RigidBody pour appliquer les forces sur la bille. Doc.

Si la vitesse de la bille est trop faible on pourra multiplier le vecteur de force par un paramètre float qui représentera la vitesse.

## Etape 3 : Créer les objets à collecter

Add Component > Physics > RigidBody
