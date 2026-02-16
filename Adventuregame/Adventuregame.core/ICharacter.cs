using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Adventuregame.core
{
    public interface ICharacter
    {
        void Attack(ICharacter target);
        string Name { get; set; }
        int Health {  get; set; }
        int Damage { get; set; }
    }

    public class Monster : ICharacter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public Monster(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        void ICharacter.Attack(ICharacter target)
        {
         
        }
    }

    public class Player : ICharacter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public Player(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        void ICharacter.Attack(ICharacter target)
        {

        }
    }
}
