using System.Collections.Generic;

namespace YetAnotherDungeonCrawler.Models
{
    public class Map
    {
        public List<Room> Rooms { get; private set; } = new List<Room>();

        public Map()
        {
            // Room 1: Only a heal potion
            ItemBase[] itemsRoom1 = new ItemBase[]
            {
                new HealPotion(1)
            };
            Enemy enemyRoom1 = null;
            Rooms.Add(new Room(itemsRoom1, enemyRoom1));

            // Room 2: A zombie with 10 attack power and 50 HP & An potion Level 2
            ItemBase[] itemsRoom2 = new ItemBase[]
            {
                new HealPotion(2)
            };
            Enemy enemyRoom2 = new Zombie(15, 50);
            Rooms.Add(new Room(itemsRoom2, enemyRoom2));

            // Room 3: The most powerful zombie with 30 attack power and 100 HP & A Wooden Sword
            ItemBase[] itemsRoom3 = new ItemBase[]
            {
                new WoodenSword(1)
            };
            Enemy enemyRoom3 = new Zombie(30, 100);
            Rooms.Add(new Room(itemsRoom3, enemyRoom3));
        }
    }
}
