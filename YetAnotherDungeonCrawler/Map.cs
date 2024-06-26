using System.Collections.Generic;

namespace YetAnotherDungeonCrawler.Models
{
    public class Map
    {

        //list of Rooms in which each Room receives an array of items and a maximum of one enemy
        public List<Room> Rooms { get; private set; } = new List<Room>();

        public Map()
        {
            // Room 1: Only a heal potion
            ItemBase[] itemsRoom1 = new ItemBase[]
            {
                new HealPotion(1)
            };
            Enemy enemyRoom1 = null;
            Rooms.Add(new Room(1, itemsRoom1, enemyRoom1));

            // Room 2: A zombie with 10 attack power and 50 HP & An potion Level 2
            ItemBase[] itemsRoom2 = new ItemBase[]
            {
                new WoodenSword(1)

            };
            Enemy enemyRoom2 = new Zombie(10, 30);
            Rooms.Add(new Room(2, itemsRoom2, enemyRoom2));

            // Room 3: A most powerfull zombie with 30 attack damage and 50 hp & a WoodenSword
            ItemBase[] itemsRoom3 = new ItemBase[]
            {
                new HealPotion(2)
            };
            Enemy enemyRoom3 = new Zombie(20, 40);
            Rooms.Add(new Room(3, itemsRoom3, enemyRoom3));

            // Room 4: A even more powerfull zombie
            ItemBase[] itemRoom4 = new ItemBase[]
            {
                new HealPotion(3)
            };
            Enemy enemyRoom4 = new Zombie(30, 70);
            Rooms.Add(new Room(4, itemRoom4, enemyRoom4));

            // Room 5: A even more powerfull zombie
            ItemBase[] itemRoom5 = new ItemBase[]
            {

            };
            Enemy enemyRoom5 = new Zombie(35, 75);
            Rooms.Add(new Room(5, itemRoom5, enemyRoom5));


        }
    }
}
