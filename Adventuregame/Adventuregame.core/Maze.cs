using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventuregame.core
{
    public class Maze
    {
        /// <summary>
        /// Here is the maze itself
        /// It will have the width & height of what the maze will look like
        /// it will also show what will show up in the maze such as items, monsters, and of course the player.
        /// </summary>
        private int width;
        private int height;
        private char[,] grid;
        private Random random = new Random();
        /// <summary>
        /// This will show the list of items that will appear on the maze
        /// </summary>
        public List<Items> Items { get; private set; } = new List<Items>();
        /// <summary>
        /// This will generate the maze of the width and height of the maze
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Maze(int width, int height)
        {
            this.width = width;
            this.height = height;
            grid = new char[height, width];
            Generate();
        }
        /// <summary>
        /// This is to generate the maze
        /// </summary>
        private void Generate()
        {
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                    grid[y, x] = random.Next(100) < 20 ? '#' : '.';
        }
        /// <summary>
        /// This will help spawn the player and the monster in the maze 
        /// it will make sure they can't spawn out of the maze
        /// </summary>
        /// <param name="character"></param>
        /// <param name="symbol"></param>
        public void PlaceCharacter(ICharacter character, char symbol)
        {
            int x, y;
            do
            {
                x = random.Next(width);
                y = random.Next(height);
            }
            while (grid[y, x] != '.');

            character.X = x;
            character.Y = y;
            grid[y, x] = symbol;
        }
        /// <summary>
        /// This will place the items in the maze and will make sure it doesn't go out of bounds.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="symbol"></param>
        public void PlaceItem(Items item, char symbol)
        {
            int x, y;
            do
            {
                x = random.Next(width);
                y = random.Next(height);
            }
            while (grid[y, x] != '.');
            item.X = x;
            item.Y = y;
            Items.Add(item);
            grid[y, x] = symbol;
        }
       /// <summary>
       /// This will place the exit in the maze when the game is start
       /// </summary>
        public void PlaceExit()
        {
            int x, y;
            do
            {
                x = random.Next(width);
                y = random.Next(height);
            }
            while (grid[y, x] != '.');
            grid[y, x] = 'E';
        }
        /// <summary>
        /// This will make sure to get the tiles and make sure they are in the right place
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public char GetTile(int x, int y)
        {
            return grid[y, x];
        }

        public void SetTile(int x, int y, char symbol)
        {
            grid[y, x] = symbol;
        }

        public bool IsInside(int x, int y)
        {
            return x >= 0 && x < width && y >= 0 && y < height;
        }
        /// <summary>
        /// This is to help show what the maze will look like when the code is running
        /// </summary>
        public void Draw()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                    Console.Write(grid[y, x]); 
                Console.WriteLine();
            }
        }
    }    
        
}
