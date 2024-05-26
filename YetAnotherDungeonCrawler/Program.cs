﻿using System;
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

            WriteOnConsole($"You are in room {room.RoomIndex} with {(room.Enemy != null ? "1 enemy" : "no enemies")} and {room.Items.Length} items.");
            WriteOnConsole($"Player HP: {player.HP}");
            if (room.Enemy != null)
            {
                WriteOnConsole(room.Enemy.ToString());
            }
            foreach (var item in room.Items)
            {
                if (item is WoodenSword woodenSword)
                {
                    WriteOnConsole(woodenSword.ToString());
                }
                else if (item is HealPotion healPotion)
                {
                    WriteOnConsole(healPotion.ToString());
                }
            }
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
