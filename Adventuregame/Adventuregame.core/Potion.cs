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
        public PotionEffects Effect { get; set; }

        public Potion(string name, string description, PotionEffects effect) : base(name, description) 
        {
            Effect = effect;
        }
    }
}
