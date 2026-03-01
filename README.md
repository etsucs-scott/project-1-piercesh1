So to make the game you must have your ICharacter interface and add in the player and monster class in to the code with the ICharacter
The player and monster must be connected to the ICharacter and make sure that both monster and lose health and be defeated.
The player itself will be capable of gaining hp, taking damage, attacking and will be capable of moving.
you must add in an item abstract class that has weapons and potions connected to it.
The weapon will be capable of giving the player extra damage when they are fighting a monster.
The amount of damage I have put in that the player will get is 5
The potion will allow the player to gain its health back or gain extra hp if they have not fought a monster yet.
The amount of health that the player will get when they get the potion is 20
you need to have the maze class to make the maze itself and it will show the player, the monster, and the items on the maze and you must find the exit.
The maze class has a Width & Height to make what the size of the maze will be
There is a PlaceCharacter that will be connected to the ICharacter to help spawn in the player and the monster
There's a PlaceItem that will be connected to item and helps spawn in the weapon and potion for the player to pick up
The PlaceExit is what will show the exit in the maze for the player to win the game.
The height of the maze should be set to (20, 10). 10 for height 20 for width and can be changed when the numbers are changed.
The GameLoop class will allow all of things in the maze to happen such as getting a game over and showing what will happen when you win.
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
