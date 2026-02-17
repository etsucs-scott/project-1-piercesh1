using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventuregame.core
{
    public class Weapon : Items
    {
        /// <summary>
        /// The weapons are connected to the items class
        /// here this will give the player a weapon once it has been picked up and give more damage.
        /// </summary>
        public int Damage { get; set; }
        public Weapon(string name, string description, int damage) : base(name, description) 
        { 
            Damage = damage;
        }
    }
}
