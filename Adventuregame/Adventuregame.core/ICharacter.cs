using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Adventuregame.core
{
    /// <summary>
    /// Here is where the Monster & Player classes will and they are connected to the ICharacter interface.
    /// </summary>
    public interface ICharacter
    {
       int Health { get; set; }
        int AttackDamage { get; set; }

        int X {  get; set; }
        int Y { get; set; }

        void Move(int dx, int dy);
        void TakeDamage(int damage);
    }
    /// <summary>
    /// The monster class will have its hp and damage show up when interacted with
    /// It should also allow the monster to spawn in the maze anywhere and allow it to take damage.
    /// </summary>
    public class Monster : ICharacter
    {
       
     
        public int Health { get; set; } = 50;
        public int AttackDamage { get; set; } = 8;

        public int X { get; set; }
        public int Y { get; set; }

        public void Move(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine($"You fought the monster! The monster took {damage} damage.");
            Console.ReadKey();
        }
    }
    /// <summary>
    /// The Player class is connected to the ICharacter where the player will have its name, hp, damage & inventory.
    /// Here it should let the player move and take damage when fighting a monster.
    /// </summary>
    public class Player : ICharacter
    {



        public int Health { get; set; } = 100;
        public int AttackDamage { get; set; } = 10;
        public int X { get; set; }
        public int Y { get; set; }

        public void Move(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine("You have taken damage!");
            Console.ReadKey();
        }

        
    }
}
