using Adventuregame.core;
using System;
using System.Numerics;
using System.Threading;


class Program 
{
    /// <summary>
    /// This should show the Maze, the player, and the monster to show up
    /// </summary>
    static Maze maze;
    static Player player = new Player();
    static Monster monster = new Monster();
    static void Main(string[] args)
    {
        //This allows you to change the look of the maze
        maze = new Maze(20, 10);
        // Here are the symbols of what will be on the maze so the player will know which one they are approaching
        maze.PlaceCharacter(player, '@');
        maze.PlaceCharacter(monster, 'M');
        ///This shows how much damage and hp the player will get it is picked up.
        maze.PlaceItem(new Weapon(5), 'W');
        maze.PlaceItem(new Potion(20), 'P');
        maze.PlaceExit();
        GameLoop();
    }

    static void GameLoop()
    {
        while(true)
        {
            Console.Clear();
            maze.Draw();

            ///when the player has 0 hp the game will end.
            Console.WriteLine($"Health: {player.Health} Damage: {player.AttackDamage}");
            if (player.Health <= 0)
            {
                Console.WriteLine("Game Over!");
                break;
            }

            var key = Console.ReadKey(true).Key;
            int dx = 0, dy = 0;

            ///This will allow the player to move using the WASD keys
            switch (key)
            {
                case ConsoleKey.W: dy = -1; 
                    break;
                case ConsoleKey.S:
                    dy = 1;
                    break;
                case ConsoleKey.A:
                    dx = -1;
                    break;
                case ConsoleKey.D:
                    dx = 1;
                    break;
            }
            TryMove(dx, dy);
        }
    }

    static void TryMove(int dx, int dy)
    {
        int newX = player.X + dx;
        int newY = player.Y + dy;

        if (!maze.IsInside(newX, newY)) 
            return;

        char target = maze.GetTile(newX, newY);
        ///this will make sure the player can not go out of the maze
        if (target == '#')
            return;
        ///When the player runs into the M, this will kick of a fight.
        ///once it hits 0 the monster will die 
        if (target == 'M')
        {
            monster.TakeDamage(player.AttackDamage);
            player.TakeDamage(monster.AttackDamage);
            if (monster.Health <= 0)
                maze.SetTile(newX, newY, '.');
            return;
        }
        ///This will allow the weapon and potion to give the effects to the player when picked up
        if (target == 'W' || target == 'P')
        {
            var item = maze.Items.Find(i => i.X == newX && i.Y == newY);
            item?.ApplyEffect(player);
            maze.Items.Remove(item);
        }
        ///This will show once the player has made it to the exit
        if (target == 'E')
        {
            Console.WriteLine("YOU DID IT! YOU FOUND THE EXIT!!!");
            Console.ReadKey();
            Environment.Exit(0);
        }
        maze.SetTile(player.X, player.Y, '.');
        player.Move(dx, dy);
        maze.SetTile(player.X, player.Y, '@');
    }
}

