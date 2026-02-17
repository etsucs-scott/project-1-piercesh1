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
        void Attack(ICharacter target);
        string Name { get; set; }
        int Health {  get; set; }
        int Damage { get; set; }
    }
    /// <summary>
    /// The monster class will have its name, hp, and damage show up when interacted with
    /// It should also allow the monster to spawn in the maze anywhere and allow it to take damage.
    /// </summary>
    public class Monster : ICharacter
    {
        private int v1;
        private int v2;
        public int x;
        public int y;

        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public Monster(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public Monster(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        void ICharacter.Attack(ICharacter target)
        {
         
        }

        public void TakeDamage(int v)
        {
            throw new NotImplementedException();
        }
    }
    /// <summary>
    /// The Player class is connected to the ICharacter where the player will have its name, hp, damage & inventory.
    /// Here it should let the player move and take damage when fighting a monster.
    /// </summary>
    public class Player : ICharacter
    {
        private int v1;
        private int v2;
        public int y;
        public int x;

        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public object Inventory { get; set; }

        public Player(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public Player(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        void ICharacter.Attack(ICharacter target)
        {

        }

        public void TakeDamage(int damage)
        {
            throw new NotImplementedException();
        }

        public void Move(int dx, int dy)
        {
            throw new NotImplementedException();
        }

        
    }
}
