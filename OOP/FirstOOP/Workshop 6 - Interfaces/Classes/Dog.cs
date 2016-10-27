using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_6___Interfaces.Interfaces;

namespace Workshop_6___Interfaces.Classes
{
    class Dog : ISpeakable
    {
        public string Speak()
        {
            return "Woof woof";
        }
    }
}
