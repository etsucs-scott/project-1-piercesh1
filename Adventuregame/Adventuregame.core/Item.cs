namespace Adventuregame.core
{
    /// <summary>
    /// The item class will show the names and the description and will have connections to the weapons and potions
    /// </summary>
    public abstract class Items
    {

        public int X { get; set; }
        public int Y { get; set; }

        public abstract void ApplyEffect(Player player);

        
    }

}
