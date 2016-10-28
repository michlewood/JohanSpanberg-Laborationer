using Labb_6___DungeonKryper.Classes.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___DungeonKryper.Other_Classes
{
    class NewGameReset
    {
        public static void ResetGame(Location currentLocation)
        {
            Player.Health = 10;
            Player.FullHealth = 10;
            Player.Moves = 10;
            Player.FullMoves = 10;
            Player.Level = 1;
            Player.Experience = 0;
            Player.MaxExperience = 1000;
            Player.noExperience = false;
            currentLocation.CurrentRoomNumber = 1000;
            currentLocation.CurrentRoomX = 0;
            currentLocation.CurrentRoomY = 0;
        }
    }
}
