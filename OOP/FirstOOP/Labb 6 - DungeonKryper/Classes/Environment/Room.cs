using Labb_6___DungeonKryper.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___DungeonKryper.Classes.Environment
{
    class Room : IEnvironment
    {

        public int Contains { get; set; }
        public string Description { get; set; }
        public string LongDescription { get; set; }
        public int EnvironmentLocationY { get; set; }
        public int EnvironmentLocationX { get; set; }
        public string Exits { get; set; }
        public int ExitNorth { get; set; }
        public int ExitSouth { get; set; }
        public int ExitWest { get; set; }
        public int ExitEast { get; set; }
        public int RoomNumber { get; set; }

        public Room()
        {
            RoomContent = new List<INonPlayerCharacter>();
        }

        public List<INonPlayerCharacter> RoomContent
        { get; private set; }
    }
}
