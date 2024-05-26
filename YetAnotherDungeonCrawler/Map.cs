using System.Collections.Generic;

namespace YetAnotherDungeonCrawler.Models
{
    public class Map
    {
        public List<Room> Rooms { get; private set; } = new List<Room>();

        public Map()
        {
            ItemBase[] items = new ItemBase[]
            {
            new HealPotion(1),
            new HealPotion(2)
            };

            Enemy[] enemies = new Enemy[]
            {
            new Zombie(15, 50),
            new Zombie(30, 100)
            };

            Rooms.Add(new Room(items, enemies));
            Rooms.Add(new Room(items, enemies));
        }
    }
}