using Labb_6___DungeonKryper.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___DungeonKryper.Other_Classes
{
    class Map
    {
        internal void ShowMap(Location currentRoom, List<IEnvironment> environments)
        {
            int xMaxBound, xMinBound, yMaxBound, yMinBound;

            xMaxBound = currentRoom.CurrentRoomX + 1;
            xMinBound = currentRoom.CurrentRoomX - 1;
            yMaxBound = currentRoom.CurrentRoomY + 1;
            yMinBound = currentRoom.CurrentRoomY - 1;

            for (int i = 0; i < environments.Count(); i++)
            {
                if (environments[i].EnvironmentLocationX <= xMaxBound
                    && environments[i].EnvironmentLocationX >= xMinBound
                    && environments[i].EnvironmentLocationY <= yMaxBound
                    && environments[i].EnvironmentLocationY >= yMinBound)
                {
                    Console.SetCursorPosition(2 + (environments[i].EnvironmentLocationY - currentRoom.CurrentRoomY), 2 - (environments[i].EnvironmentLocationX - currentRoom.CurrentRoomX));
                    if (currentRoom.CurrentRoomX == environments[i].EnvironmentLocationX
                        && currentRoom.CurrentRoomY == environments[i].EnvironmentLocationY)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("@");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("#");
                    } 
                }
            }
            Console.SetCursorPosition(0, 5);
        }
    }
}
