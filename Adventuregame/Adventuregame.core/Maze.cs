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
        public int Width { get; set; }
        public int Height { get; set; }

        public char [,] Grid { get; set; }
        
        public List<Monster> Monsters { get; set; }

        
        /// <summary>
        /// This will show all of the things that will show in the maze.
        /// </summary>
        public (int x, int y) Exit;
        public (int x, int y) Player;
        public (int x, int y) Weapon;
        public (int x, int y) Potion;
        public (int x, int y) Monster;
        public Maze(int width, int height)
        {
            Width = width;
            Height = height;
            Grid = new char[Width, Height];
            GenerateMaze();
        } 

        private void GenerateMaze()
        {
            ///This will generate a random maze everytime you start up a new game.
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
            /// This will show where each thing will spawn on the map and the @ symbol is the player.
            Grid[Exit.y, Exit.x] = 'E';
            Grid[Player.y, Player.x] = '@';
            Grid[Weapon.y, Weapon.x] = 'W';
            Grid[Potion.y, Potion.x] = 'P';
            Grid[Monster.y, Monster.x] = 'M';

        }

        /// <summary>
        /// This should keep the player from going out of bounds in they are near the wall.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool IsWalkable(int x, int y) 
        { 
            return Grid [x, y] != '#';
        }

        
    }    
        
}
