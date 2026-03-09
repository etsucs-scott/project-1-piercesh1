##Adventure Game
This project is an adventure maze game that was made in C# 
Here the player must make it to an exit, but must be careful as there are monsters in the maze.

##Features
There is a maze that will be randomly generated everytime a player starts a game
The player can move to different tiles by using WASD.
You have a weapon that will give you more damage and a potion that will give you health.
Your health and damage will show
There is a win lose condition

##Build Instructions
requires NET.SDK

Build the project with:
dotnet build

##Run Instructions
Run the game with:
dotnet run

##Runtime Instructions
Use the WASD Keys to move the player which is the @ symbol.
You can encounter a monster that has an M symbol
the combat will begin when you approach a monster. The monster will despawn once it has 0 hp.

##Win Condition
The player must make it to the exit tile which is the E symbol, but they need to have hp if they want to make it.

##Lose Condition
The player must have 0 hp for them to lose the game

##Project structure
AdventureGame.Console - handles input/output
AdventureGame.Core - Contains the Game Logic

#UML Diagram
The UML diagram should be set as UML Diagram AdventureGame.PNG

#Author
Sid Pierce
CSCI 1260 - Object Oriented Programming
