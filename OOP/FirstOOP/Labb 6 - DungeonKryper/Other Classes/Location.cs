using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___DungeonKryper.Other_Classes
{
    class Location
    {
        public int CurrentRoomY { get; set; }
        public int CurrentRoomX { get; set; }
        public int CurrentRoomContents { get; set; }
        public int CurrentRoomNumber { get; set; }
        public string AvailableExits { get; set; }
        public int PossibleExitNorth { get; set; }
        public int PossibleExitSouth { get; set; }
        public int PossibleExitEast { get; set; }
        public int PossibleExitWest { get; set; }
    }
}
