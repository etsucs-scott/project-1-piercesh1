using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventuregame.core
{
    public enum PotionEffects { Healing, IncreasingAttack, IncreaseHealth}
    public class Potion : Items
    {
        /// <summary>
        /// The Potion is connected to the items class
        /// This will give the player an effect and give them health once picked up
        /// </summary>
        public PotionEffects Effect { get; set; }
        public int PotionEffects { get; set; }

        public Potion(string name, string description, PotionEffects effect) : base(name, description) 
        {
            Effect = effect;
        }
    }
}
