using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventuregame.core
{
    public class Maze
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public char [,] Grid { get; set; }
        
        public List<Monster> Monsters { get; set; }

        public Weapon Weapon {  get; set; }
        public Potion Potion { get; set; }

        public (int x, int y) Exit;
        public (int x, int y) Player;
        public Maze(int width, int height)
        {
            Width = width;
            Height = height;
            Grid = new char[Width, Height];
            GenerateMaze();
        } 

        private void GenerateMaze()
        {
            Random random = new Random();
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    Grid[y, x] = '.';
                }
            }

           for (int i = 0; i < Height; i++)
            {
                Grid[i, 0] = '#';
                Grid[i, Width - 1] = '#';
                Grid[i, Height - 1] = '#';
            }
            Exit = (Width - 2, Height - 2);
            Grid[Exit.y, Exit.x] = 'E';

            Grid[Player.y, Player.x] = '@';

        }

        public bool IsWalkable(int x, int y) 
        { 
            return Grid [x, y] != '#';
        }

        
    }    
        
}
