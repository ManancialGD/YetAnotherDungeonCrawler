using System.Collections.Generic;

namespace YetAnotherDungeonCrawler.Models
{
    class Map
    {
        public Room[] Rooms { get; private set; }
        int roomsAmount = 10;

        public Map()
        {
            Rooms = new Room[roomsAmount];
        }

        public void CreateMap()
        {
            List<ItemBase> items = new List<ItemBase>
            {
                new HealPotion(10)
            };

            List<Enemy> enemies = new List<Enemy>
            {
                new Zombie(10, 100)
            };

            Room room1 = CreateRoom(items.ToArray(), enemies.ToArray());
            Rooms[0] = room1;

            // Initialize remaining rooms to avoid null references
            for (int i = 1; i < Rooms.Length; i++)
            {
                Rooms[i] = CreateRoom(new ItemBase[0], new Enemy[0]);
            }
        }

        public Room CreateRoom(ItemBase[] items, Enemy[] enemies)
        {
            return new Room(items, enemies);
        }
    }
}
