using Labb_6___DungeonKryper.Classes.Objects;
using Labb_6___DungeonKryper.Interfaces;
using Labb_6___DungeonKryper.Other_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___DungeonKryper
{
    class UI
    {
        public void ShownUserInterface(Map map, Runtime runtime, UI userInterface, Location currentLocation, PlayerControls playerControls, List<IEnvironment> environments)
        {
            bool gameLoop = true;
            while (gameLoop)
            {
                runtime.ExitUpdater(currentLocation, runtime, currentLocation.CurrentRoomNumber);
                runtime.UpdateList(currentLocation.CurrentRoomNumber);
                map.ShowMap(currentLocation, environments); // Not implemented yet.

                Console.WriteLine("━━━");
                Console.WriteLine(runtime.RoomDescription(map, 
                                                            currentLocation, 
                                                            currentLocation.CurrentRoomX, 
                                                            currentLocation.CurrentRoomY, 
                                                            currentLocation.CurrentRoomNumber, 
                                                            runtime, 
                                                            userInterface));

                Console.WriteLine("{0} HP - {1} Stamina. TNL: {2} Exits: {3}", Player.Health, 
                                                                                Player.Moves, 
                                                                                (Player.MaxExperience - Player.Experience), 
                                                                                runtime.Exits);

                Console.WriteLine("X: {0} Y: {1}", currentLocation.CurrentRoomX, 
                                                    currentLocation.CurrentRoomY);
                Console.WriteLine("━━━");
                Console.Write("Command: ");

                runtime.Exits = "";
                playerControls.UserInput(userInterface, 
                                            runtime, 
                                            currentLocation, environments, currentLocation.CurrentRoomNumber);

                Console.Clear();
            }
        }
    }
}
