using System;
using YetAnotherDungeonCrawler.Models;
using YetAnotherDungeonCrawler.Views;

namespace YetAnotherDungeonCrawler.Controllers
{
    class Controller
    {
        public Map map;

        public Controller()
        {
            map = new Map();
        }

        public void Run()
        {
            GenerateMap();

            foreach (Room r in map.Rooms)
            {
                foreach (ItemBase item in r.Items)
                {
                    Program.WriteOnConsole(item.ToString());
                }

                foreach (Enemy enemy in r.Enemies)
                {
                    Program.WriteOnConsole(enemy.ToString());
                }
            }
        }

        public void GenerateMap()
        {
            map.InitializeVariables();
            map.InitializeMap();
        }
    }
}
