So to make the game you must have your ICharacter interface and add in the player and monster class in to the code with the ICharacter
you must add in an item abstract class that has weapons and potions connected to it.
you need to have the maze class to make the maze itself and it will show the player, the monster, and the items on the maze and you must find the exit.
to move around the maze you must use the WASD keys.
If you run into an M you will fight the monster.
If you run into a P you get a potion that should give you health
If you run into a W you will get a weapon.
If you run into a E you will escape and win the game
To win the game you must make it to the exit
If you lose all your health your game is over.
For the UML diagram I made sure to list off the important things such as the classes
The ICharacter is the interface and that will be connected to most classes such as the player and the monster
The player will be capable of moving, picking up items & fighting a monster when approaching one.
The monster can spawn in the maze and will have its name, hp & damage show up.
The items class will have the names and description for the weapons and potions
The weapon class is connected to the items class and has damage connected
The potion class is connected to items and will have health connected to it
The maze will be the thing that adds everything and connected to all the classes
