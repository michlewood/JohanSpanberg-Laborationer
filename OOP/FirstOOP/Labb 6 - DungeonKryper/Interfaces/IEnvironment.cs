using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___DungeonKryper.Interfaces
{
    interface IEnvironment
    {
        List<INonPlayerCharacter> RoomContent { get; }

        string Description { get; set; }
        string LongDescription { get; set; }
        int Contains { get; set; }
        int EnvironmentLocationY { get; set; }
        int EnvironmentLocationX { get; set; }
        string Exits { get; set; }
        int ExitNorth { get; set; }
        int ExitSouth { get; set; }
        int ExitWest { get; set; }
        int ExitEast { get; set; }
        int RoomNumber { get; set; }

    }
}
