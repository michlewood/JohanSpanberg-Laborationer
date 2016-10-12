using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvochPolymorfism
{
    class Dog : Mammal
    {
        public override int NumberOfLegs()
        {
            return 4;
        }
        public override bool CanSwim()
        {
            return true;
        }
        public override bool CanRun()
        {
            return true;
        }
        public override bool CanFly()
        {
            return false;
        }
        public override string Move()
        {
            return "Hunden springer på hundsätt."; 
        }
        public override string Looks()
        {
            return "Hunden ser väldigt fluffig och snäll ut.";
        }
        public override string Sound()
        {
            return "Hunden skäller.";
        }
    }
}
