# Eating Monsters Game
The following were the steps of how this small 2d game called 'Eating Monsters' came together:

1. Download the bird package from this website: https://game.courses/birds/
2. The aim of this project is to use this package features and try to modify them/add some features by using the appropriate codes according to the lecture of the IntroToUnity along with Jason Weimann 'Unity Game Development for Beginners' video/ courses guidlance that can be accessed here: https://www.youtube.com/watch?v=Lu76c85LhGY&t=8712s . In short we start with builiding up our Assets , setting background and the coding with the initial features like making the bird flying or preventing them to fall and so on.
3. The short description of the game is as follow- the player is a bird who in order to progress to another level have to kill all the monster in given level.
4. We start with defining the environment and some initial functions for player such as using the mouse by clicking Up and Down as well as Dragging to change the color and position of the player.
5. Creating a 2D Character with a SpriteRenderer, Physics with Rigidbody2D, Collisions, PolygonCollider2D, BoxCollider2D for the bird and the background. We also use this functions to change the color of the player. 
6. We use mouse functions such as " OnMouseDown" to control the player by using the mouse. In addition by dragging the mouse we can move the bird. 
7. In the nest step, we have to define the camera position by suing the transform function.
8. Backgrounds, Sprite Tiling, SortingLayers, OrderInLayer
9. Now we should define a function that the bird can fly. So, we need to define the current position and the direction as well by using Vector. 
10. In this stage, we define Serialize Field which is a new type of variable. We can change the LunchForce which now is added to the inspector to change the bird's force to hit the goal. 
11. Here, we add the crates. The task is to hit the bird to the crate in this level of the game. 
12. By using the OnCollisionEnters2D we can define a function to reset the bird's position (back to the starting position). Furthermore, we choose to freeze the rotation in Z direction for the bird in this game. 
13. Coroutines was used to define a delaying reset because without this the reset was happened too quickly. 
14. After creating the bird asset and assigning the features we move to create another asset - monster.
15. We look at different ways that enemy ( a monster ) could die – for example from box collision or hit by the bird. 
16. The enemy will be killed by crate, for example, by using the Collision Normal function. 
17. Creating simple particle on our monster to add the power or die better! after adding the sprite function, when something hits the monster their eyes get close then die. By adding the particle system, the particles release when the monster die.
18. However, we saw multiple dying. So, used HasDiedCheck to prevent multiple deaths.
19. Building up another level – when we kill all the monster we progress to another level. The level 2 has more monsters, crates and particles. 
20. After creating level 2 we need to write some code to progress from one level to another – we are going to create level progression control – simple script that keeps track of how many monsters are alive in our level and progresses to another level once all of the monsters are death. To do that we going to create another code script.
12.In order for level change to work we need to go to file on unity and Build settings to change the default scenes we like.
21. To have a more efficient camera, we have to install Cinemachine Camera Controller & TargetGroup Camera. 
22. The next step is Prefab Setup and Level Completion. we created the prefab folder. 
22. The next step is Prefab Setup and Level Completion. we created the prefab folder.
23. Addition to his game- we added music , we added main menu scene with play button that takes you to level 0 , we added closing off scene  with button that get's you back to play the game again. We also added level 0 which is a bit different than other scenes- in order to progress you have to last without dying - you die if you touch red brick wall behind you. In order to get to level 1 you have to let 50 monsters pass the red brick wall - they count is randomized - not every mosnters counts to make it more challenging - also after the 1st group of monsters passing they position is randomized as well. We also added the 'creepy guys' falling from the sky an dthey are able to kill our player - that wasnt in his game. And lastly we added the closing scene- you won along with music and button to play again.
