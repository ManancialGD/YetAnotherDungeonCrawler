namespace YetAnotherDungeonCrawler.Models
{
    public class Room
    {
        public ItemBase[] Items { get; private set; }
        public Enemy Enemy { get; private set; }

        public Room(ItemBase[] items, Enemy enemy)
        {
            Items = items ?? new ItemBase[0];
            Enemy = enemy;
        }

        public void RemoveEnemy()
        {
            Enemy = null;
        }

        public void ClearItems()
        {
            Items = new ItemBase[0];
        }
    }
}
