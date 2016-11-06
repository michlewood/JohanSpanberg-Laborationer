using Labb_6___DungeonKryper.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___DungeonKryper.Classes.Objects.Armor
{
    class ArmorItem : IItems
    {
        public int Position { get; set; }
        public string ArmorName { get; set; }
        public int ArmorStrength { get; set; }
        public int ArmorWorth { get; set; }
        public int ArmorWeight { get; set; }
    }
}
