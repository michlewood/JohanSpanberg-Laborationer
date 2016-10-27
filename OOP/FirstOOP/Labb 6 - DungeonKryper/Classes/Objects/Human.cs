using Labb_6___DungeonKryper.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___DungeonKryper.Classes.Objects
{
    class Human : INonPlayerCharacter
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public string Speak { get; set; }
        public int ObjectLocationY { get; set; }
        public int ObjectLocationX { get; set; }
        public int ObjectNumber { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }
    }
}
