namespace Adventuregame.core
{
    
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
