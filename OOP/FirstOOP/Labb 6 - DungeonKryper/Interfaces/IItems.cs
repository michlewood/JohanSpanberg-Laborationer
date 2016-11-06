using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___DungeonKryper.Interfaces
{
    interface IItems
    {
        int Position { get; set; }
        string ArmorName { get; set; }
        int ArmorStrength { get; set; }
        int ArmorWorth { get; set; }
        int ArmorWeight { get; set; }
    }
}
