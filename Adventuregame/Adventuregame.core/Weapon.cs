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
        public Weapon(int damage) 
        {
            Damage = damage;
        }
        /// <summary>
        /// This will allow the player to get more damage when picked up
        /// </summary>
        /// <param name="player"></param>
        public override void ApplyEffect(Player player)
        {
            player.AttackDamage += Damage;
            Console.WriteLine("You found a Weapon. Your damage has increased");
        }
    }
}
