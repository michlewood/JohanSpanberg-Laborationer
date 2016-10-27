using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___DungeonKryper
{
    class UI
    {
        public int CurrentRoomY { get; set; }
        public int CurrentRoomX { get; set; }
        public int CurrentRoomContents { get; set; }
        public int CurrentRoomNumber { get; set; }
        public int Health { get; set; }
        public int FullHealth { get; set; }
        public int Moves { get; set; }
        public int FullMoves { get; set; }
        public int Level { get; set; }
        public string AvailableExits { get; set; }
        public int PossibleExitNorth { get; set; }
        public int PossibleExitSouth { get; set; }
        public int PossibleExitEast { get; set; }
        public int PossibleExitWest { get; set; }

        public void ShownUserInterface(Runtime runtime, UI userInterface)
        {
            CurrentRoomNumber = 1000;
            Health = 10;
            FullHealth = 10;
            Moves = 10;
            FullMoves = 10;
            CurrentRoomX = 0;
            CurrentRoomY = 0;
            bool gameLoop = true;
            while (gameLoop)
            {
                runtime.UpdateList(CurrentRoomNumber);
                Console.WriteLine(runtime.RoomDescription(CurrentRoomX, CurrentRoomY, CurrentRoomNumber, runtime, userInterface));
                Console.Write("{0} HP - {1} Stamina. Exits: {2}. ", Health, Moves, AvailableExits);
                Console.WriteLine("X: {0} Y: {1}", CurrentRoomX, CurrentRoomY);
                Console.WriteLine("---");
                Console.Write("Command: ");
                runtime.UserInput(userInterface, runtime);
                Console.Clear();
            }
            
        }

    }
}
