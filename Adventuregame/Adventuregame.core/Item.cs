namespace Adventuregame.core
{
    /// <summary>
    /// The item class will show the names and the description and will have connections to the weapons and potions
    /// </summary>
    public abstract class Items
    {
       public string Name { get; set; }
        public string Description { get; set; }

        public Items(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }

}
