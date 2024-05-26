using System;
using YetAnotherDungeonCrawler.Models;
using YetAnotherDungeonCrawler.Views;

namespace YetAnotherDungeonCrawler.Controllers
{
    class Controller
    {
        public Map Map { get; private set; }
        public Player Player { get; private set; }
        private int currentRoomIndex;
        private bool justEnteredRoom;
        public bool gameFinished = false;
        private bool unknownCommand = false;

        public Controller()
        {
            // Instantiate player and Map
            Map = new Map();
            Player = new Player("Hero");

            currentRoomIndex = 0; // what room are the player in

            justEnteredRoom = true; // This is to prevent the enemy that he starts attacking only if the player hasn't just entered the room
        }

        public void Run()
        {
            while (!gameFinished)
            {
                Room currentRoom = Map.Rooms[currentRoomIndex];



                if (!justEnteredRoom && currentRoom.Enemy != null && !unknownCommand)
                {
                    string attackMessage = currentRoom.Enemy.Attack(Player);
                    Program.WriteOnConsole(attackMessage);

                    if (Player.HP <= 0)
                    {
                        Program.WriteOnConsole("[!] You have been killed by the enemy. Game Over.");
                        break;
                    }
                }
                else
                {
                    justEnteredRoom = false;
                }
                Program.DisplayRoomInfo(currentRoom, Player);

                DisplayAvailableCommands(currentRoom);
                string command = Program.GetPlayerCommand();
                ProcessCommand(command, currentRoom);

                
                if (Player.HP <= 0)
                {
                    Program.WriteOnConsole("[!] You have died. Game Over.");
                    break;
                }

                // Add two empty lines for spacing
                Program.WriteOnConsole("\n");
            }
        }

        private void DisplayAvailableCommands(Room currentRoom)
        {
            Program.WriteOnConsole("Available commands:");
            if (currentRoom.Enemy != null)
            {
                Program.WriteOnConsole(" | attack - Attack the enemy");
            }
            else
            {
                Program.WriteOnConsole(" | move - Move to the next room");

                if (currentRoom.Items.Length > 0)
                {
                    Program.WriteOnConsole(" | pickup - Pick up items in the room");
                }
            }
            Program.WriteOnConsole(" | inventory - Open the inventory");
        }

        private void ProcessCommand(string command, Room currentRoom)
        {
            switch (command.ToLower())
            {
                case "move":
                    if (currentRoom.Enemy == null)
                    {
                        MoveToNextRoom();
                    }
                    else
                    {
                        Program.WriteOnConsole("You cannot move until the enemy is defeated.");
                    }
                    unknownCommand = false;
                    break;
                case "attack":
                    if (currentRoom.Enemy != null)
                    {
                        string attackMessage = Player.Attack(currentRoom.Enemy);
                        Program.WriteOnConsole(attackMessage);
                        if (currentRoom.Enemy.HP <= 0)
                        {
                            Program.WriteOnConsole("You have killed the enemy.");
                            currentRoom.RemoveEnemy();
                            if(currentRoom.RoomIndex == 5){

                                FinishGame();

                            }
                        }
                    }
                    else
                    {
                        Program.WriteOnConsole("There are no enemies to attack.");
                    }
                    unknownCommand = false;
                    break;
                case "pickup":
                    if (currentRoom.Enemy == null)
                    {
                        PickUpItems(currentRoom);
                    }
                    else
                    {
                        Program.WriteOnConsole("You cannot pick up items until the enemy is defeated.");
                    }
                    unknownCommand = false;
                    break;
                case "inventory":
                    OpenInventory();
                    unknownCommand = false;
                    break;
                default:
                    Program.WriteOnConsole("Unknown command.");
                    unknownCommand = true;
                    break;
            }
        }

        private void FinishGame(){
            gameFinished = false;
            Program.WriteOnConsole("Congrats, you have finished the game!");
        }
        private void MoveToNextRoom()
        {
            if (currentRoomIndex < Map.Rooms.Count - 1)
            {
                currentRoomIndex++;
                justEnteredRoom = true;
                Program.WriteOnConsole("You moved to the next room.");
            }
            else
            {
                Program.WriteOnConsole("There are no more rooms to move to.");
            }
        }

        private void PickUpItems(Room currentRoom)
        {
            if (currentRoom.Items.Length > 0)
            {
                foreach (var item in currentRoom.Items)
                {
                    string pickUpMessage = Player.PickUpItem(item);
                    Program.WriteOnConsole(pickUpMessage);
                }
                currentRoom.ClearItems(); // Clear items from the room after picking up
            }
            else
            {
                Program.WriteOnConsole("There are no items to pick up.");
            }
        }

        private void OpenInventory()
        {
            Program.DisplayInventory(Player);

            Program.WriteOnConsole("Enter the number of the item you want to use/equip or '0' to cancel: ");

            if (int.TryParse(Console.ReadLine(), out int itemIndex) && itemIndex >= 0)
            {
                if (itemIndex == 0)
                {
                    Program.WriteOnConsole("Cancelled.");
                    Program.BigSpace();
                }
                else
                {
                    string useMessage = Player.InteractWithItem(itemIndex - 1); // Convert to zero-based index
                    Program.WriteOnConsole(useMessage);
                }
            }
            else
            {
                Program.WriteOnConsole("Invalid input.");
            }
        }
    }
}
