using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvochPolymorfism
{
    class Eagle : Bird
    {
        public override int NumberOfLegs()
        {
            return 2;
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
            return true;
        }
        public override string Move()
        {
            return "Örnen flaxar fram.";
        }
        public override string Looks()
        {
            return "Örnen ser väldigt aggressiv ut.";
        }
        public override string Sound()
        {
            return "Örnen skriker.";
        }
    }
}
