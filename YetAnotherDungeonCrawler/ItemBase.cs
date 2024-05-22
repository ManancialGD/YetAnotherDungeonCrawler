namespace YetAnotherDungeonCrawler.Models
{
    /// <summary>
    /// This class will be a base for other items
    /// </summary>
    abstract class ItemBase
    {
        // Variables
        public abstract string ItemType { get; set; }

        // Methods
        public abstract void Use(Player player);
        public abstract void Equip();
    }
}
