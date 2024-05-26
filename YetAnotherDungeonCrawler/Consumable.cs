namespace YetAnotherDungeonCrawler.Models
{
    public abstract class Consumable : ItemBase
    {   
        public abstract string Use(Player player);
    }
}
