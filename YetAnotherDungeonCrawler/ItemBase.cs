namespace YetAnotherDungeonCrawler.Models
{
    /// <summary>
    /// This class will be a base for other items
    /// </summary>
    public abstract class ItemBase
    {
        public abstract bool IsEquiped { get; set; }
        // Methods
        public abstract string Use(Player player);
        public abstract void Equip();
    }
}
