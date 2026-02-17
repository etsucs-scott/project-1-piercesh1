using Adventuregame.core;

static void Main(string[] args)
{
    ///This will help generate the maze
    Maze maze = new Maze(20, 10);
    /// Here we have the player that can be controlled by WASD
    Player player = new Player(1, 1);
    /// This will show the monsters that will be on the maze
    List<Monster> monsters = new List<Monster>();
    {
        new Monster(5, 5);
        new Monster(10, 3);
    }
    ///<summery>
    /// This will show the items that will spawn on the maze
    /// </summery>
    List<Items> items = new List<Items>()
    {
        new Weapon { Name = "Sword", Damage = 15 },
        new Potion { Name = "Health Potion", PotionEffects = 25 }
    };
    /// This will put the items in a spot on the maze that the player can grab
    maze.Grid[2, 2] = 'I';
    maze.Grid[3, 4] = 'I';

    while (true)
    {
        ///<summery>
        ///This will tell you whether the player has found the exit or died.
        /// </summery>
        (player, monsters);
        if (player.Health <= 0)
        {
            Console.WriteLine("You are dead.");
            break;
        }
        ///This will show up once the player has made it to the exit
        if (player.x == maze.Exit.x && player.y == maze.Exit.y)
        {
            Console.WriteLine("You did it! You found the exit! Well done!");
            break;
        }
        ///<summery>
        /// This will allow you to either use the arrow keys or WASD
        /// I used the switch command to help me put in the arrowkeys and WASD.
        /// </summery>
        ConsoleKeyInfo key = Console.ReadKey(true);
        int dx = 0, dy = 0;

        switch (key.Key)
        {
            case ConsoleKey.W:
            case ConsoleKey.UpArrow:
                dy = -1;
                break;
            case ConsoleKey.S:
            case ConsoleKey.DownArrow:
                dy = 1;
                break;
            case ConsoleKey.A:
            case ConsoleKey.LeftArrow:
                dx = -1;
                break;
            case ConsoleKey.D:
            case ConsoleKey.RightArrow:
                dx = 1;
                break;
            default: continue;

        }

        int newX = player.x + dx;
        int newY = player.y + dy;

        if (!maze.IsWalkable(newX, newY)) continue;

        ///When a player fights a monster and attacks it, it will show what damage has been done to the monster
        Monster monster = monsters.Find(Monster => Monster.x == newX && Monster.y == newY);
        if (monster != null)
        {
            player.TakeDamage(monster.Damage);
            monster.TakeDamage(20);
            Console.WriteLine("You fought a monster! Took {monster.Damage} damage");
            if (monster.Health <= 0)
            {
                monsters.Remove(monster);
                Console.ReadKey();
                continue;
            }
        }
        ///<summery>
        ///This will show the item locations in the maze
        /// </summery>
        if (maze.Grid[newY, newX] == 'I')
        {
            var keyItem = (newX, newY);
            if (itemLocations.ContainsKey(keyItem))
            {
                var item = itemLocations[keyItem];
                Console.WriteLine($"You picked up:{item.Name}");
                itemLocations.Remove(keyItem);
                maze.Grid[newY, newX] = '.';
                Console.ReadKey();
            }
        }
        player.Move(dx, dy);
    }
}