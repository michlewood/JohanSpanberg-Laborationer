using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvochPolymorfism
{
    class Snake : Reptile
    {
        public override int NumberOfLegs()
        {
            return 0;
        }
        public override bool CanSwim()
        {
            return true;
        }
        public override bool CanRun()
        {
            return false;
        }
        public override bool CanFly()
        {
            return false;
        }
        public override string Move()
        {
            return "Ormen ringlar fram.";
        }
        public override string Looks()
        {
            return "Ormen ser fjällig ut.";
        }
        public override string Sound()
        {
            return "Ormen väser.";
        }
    }
}
