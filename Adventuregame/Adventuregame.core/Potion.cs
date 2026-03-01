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

        public Potion(int effect) 
        {
            PotionEffects = effect;
        }
        /// <summary>
        /// This should allow the player to get hp when picked up
        /// </summary>
        /// <param name="player"></param>
        public override void ApplyEffect(Player player)
        {
              player.Health += PotionEffects;
            Console.WriteLine("You found a potion. Your health has been restored");
        }
    }
}
