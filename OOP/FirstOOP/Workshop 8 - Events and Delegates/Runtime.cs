using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_8___Events_and_Delegates
{
    class Runtime
    {
        public delegate void MyDelegate(string message); // delegates är som en variabel som innehåller en metod.
                // Delegaten och Delegatmetoden måste ha samma typ av returvärde.

        public void DelegateMethod(string message) // Definerar metoden som delegaten MyDelegate ska innehålla
        {
            Console.WriteLine(message);
        }

        public void Start()
        {
            MyDelegate del1 = new MyDelegate(DelegateMethod);

            del1("Hello world!");
        }
    }
}
