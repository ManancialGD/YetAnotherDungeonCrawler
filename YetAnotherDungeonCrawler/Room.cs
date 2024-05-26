namespace YetAnotherDungeonCrawler.Models
{
    /// <summary>
    /// Represents an area of the Dungeon
    /// Can have an enemy, an item or both
    /// </summary>
    public class Room
    {
        public ItemBase[] Items { get; private set; }
        public Enemy[] Enemies { get; private set; }

        public Room(ItemBase[] items, Enemy[] enemies)
        {
            Items = items ?? new HealPotion[0];
            Enemies = enemies ?? new Enemy[0];
        }
    }
}
