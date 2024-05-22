using System;
using YetAnotherDungeonCrawler.Controllers;

namespace YetAnotherDungeonCrawler.Views
{
    /// <summary>
    /// This will be the view
    /// </summary>
    class Program
    {
        static Controller controller;
        static void Main(string[] args)
        {
            controller = new Controller();
            controller.Run();
        }

        public static void WriteOnConsole(string s)
        {
            Console.WriteLine(s);
        }
    }
}
