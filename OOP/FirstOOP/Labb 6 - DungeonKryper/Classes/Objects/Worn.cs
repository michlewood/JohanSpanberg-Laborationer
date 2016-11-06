using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb_6___DungeonKryper.Interfaces;

namespace Labb_6___DungeonKryper.Classes.Objects
{
    class Worn : IEquipment
    {
        public int Position { get; set; }
        public string ArmorName { get; set; }
        public int ArmorStrength{ get; set; }
        public int ArmorWorth{ get; set; }
        public int ArmorWeight{ get; set; }

        public Worn()
        {
            WornEquipment = new List<IEquipment>();
        }

        public List<IEquipment> WornEquipment
        { get; private set; }

        public List<IItems> ArmorSlotContains
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
