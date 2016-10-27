using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_6___Interfaces.Interfaces;

namespace Workshop_6___Interfaces.Classes
{
    // En klass som implementerar ett interface definerar _hur_ saker görs, Egenskaper kort och gott.
    // Vi måste i klasser som ärver ett interface definera hur beteenden används.
    class Bird : IFlyable, ISpeakable
    {
        public string color { get; set; }

        public int TopSpeed { get; set; }

        public void Fly()
        {
            Console.Write("Flap flap");
        }

        public string Speak()
        {
            return "Tweet tweet";
        }
    }
}
