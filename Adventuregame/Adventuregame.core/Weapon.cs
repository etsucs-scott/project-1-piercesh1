using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventuregame.core
{
    public class Weapon : Items
    {
        public int Damage { get; set; }
        public Weapon(string name, string description, int damage) : base(name, description) 
        { 
            Damage = damage;
        }
    }
}
