using System;
using YetAnotherDungeonCrawler.Controllers;
using YetAnotherDungeonCrawler.Models;

namespace YetAnotherDungeonCrawler.Views
{
    class Program
    {
        static Controller controller;

        static void Main(string[] args)
        {
            controller = new Controller();
            controller.Run();
        }

        public static void DisplayRoomInfo(Room room, Player player)
        {
            WriteOnConsole($"You are in a room with {(room.Enemy != null ? "1 enemy" : "no enemies")} and {room.Items.Length} items.");
            WriteOnConsole($"Player HP: {player.HP}");
            if (room.Enemy != null)
            {
                WriteOnConsole(room.Enemy.ToString());
            }
            foreach (var item in room.Items)
            {
                WriteOnConsole(item.ToString());
            }
        }

        public static string GetPlayerCommand()
        {
            WriteOnConsole("Enter a command: ");
            return Console.ReadLine();
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
    }
}
