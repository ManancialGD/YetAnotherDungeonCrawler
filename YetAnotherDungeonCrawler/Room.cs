namespace YetAnotherDungeonCrawler.Models
{
    /// <summary>
    /// Represents an area of the Dungeon
    /// Can have an enemy or an item or both
    /// </summary>
    class Room
    {
        public ItemBase[] Items { get; private set; }
        public Enemy[] Enemies { get; private set; }

        public Room(ItemBase[] items, Enemy[] enemies)
        {
            Items = items ?? new ItemBase[0];
            Enemies = enemies ?? new Enemy[0];
        }
    }
}
