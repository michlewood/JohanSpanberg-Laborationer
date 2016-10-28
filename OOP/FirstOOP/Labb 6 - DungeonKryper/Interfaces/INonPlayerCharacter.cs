using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___DungeonKryper.Interfaces
{
    interface INonPlayerCharacter
    {
        string Description { get; set; }
        string LongDescription { get; set; }
        string Name { get; set; }
        string Speak { get; set; }
        int ObjectLocationY { get; set; }
        int ObjectLocationX { get; set; }
        int ObjectNumber { get; set; }
        int Health { get; set; }
        int Level { get; set; }
    }
}
