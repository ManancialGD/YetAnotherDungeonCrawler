using System;
using YetAnotherDungeonCrawler.Controllers;
using YetAnotherDungeonCrawler.Models;

namespace YetAnotherDungeonCrawler.Views
{
    class Program
    {
        static Controller controller;
        static bool gameStarted = true;

        static void Main(string[] args)
        {
            controller = new Controller();
            controller.Run();
        }

        public static void DisplayRoomInfo(Room room, Player player)
        {

            if (gameStarted)
            {
                BigSpace();
                gameStarted = false;
            }

            WriteOnConsole($"You are in room {room.RoomIndex}");
            DisplayPlayerHealth(player);
            WriteOnConsole("");
            if (room.Enemy != null)
            {// show the enemy in the room, if there is one
                WriteOnConsole("Room enemies:");
                WriteOnConsole(" | " + room.Enemy.ToString());
            }
            if (room.Enemy != null) WriteOnConsole("");
            foreach (var item in room.Items)
            { // show the items on the room depending on type
                WriteOnConsole("Room items:");
                if (item is WoodenSword woodenSword)
                {
                    WriteOnConsole(" | " + woodenSword.ToString());
                }
                else if (item is HealPotion healPotion)
                {
                    WriteOnConsole(" | " + healPotion.ToString());
                }
            }
            if (room.Items.Length > 0) WriteOnConsole("");
        }

        public static string GetPlayerCommand()
        {
            WriteOnConsole("Enter a command: ");
            string command = Console.ReadLine();
            BigSpace();

            return command;
        }


        public static void WriteOnConsole(string message)
        {
            Console.WriteLine(message);
        }

        public static void DisplayInventory(Player player)
        {
            WriteOnConsole("Inventory:");
            for (int i = 0; i < player.Inventory.Count; i++)
            {
                WriteOnConsole($"{i + 1}: {player.Inventory[i]}");
            }
        }

        public static void DisplayPlayerHealth(Player player)
        {
            WriteOnConsole($"Player HP: {player.HP}");
        }

        static public void BigSpace()
        {
            for (int i = 0; i < 15; i++)
            {
                WriteOnConsole("\n");
            }
        }
    }
}
