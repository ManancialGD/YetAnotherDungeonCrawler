using System.Collections.Generic;

namespace YetAnotherDungeonCrawler.Models
{
    class Map
    {

        private ItemBase[] items;
        private Enemy[] enemies;

        public Room[] Rooms = new Room[2];
        public void InitializeVariables()
        {
            // Inicializar o array usando a sintaxe correta em C#
            items = new ItemBase[]
            {
            new HealPotion(1),
            new HealPotion(2)
            };

            enemies = new Enemy[]
            {
            new Zombie(15, 50),
            new Zombie(30, 100)
            };
        }

        public void InitializeMap()
        {
            Rooms[0] = new Room(items, enemies);
            Rooms[1] = new Room(items, enemies);
        }


        public Map()
        {
            InitializeVariables();
            InitializeMap();
        }

        public void CreateMap()
        {
            List<ItemBase> items = new List<ItemBase>
            {
                new HealPotion(3)
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
