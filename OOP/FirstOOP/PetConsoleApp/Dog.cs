using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetConsoleApp
{
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }

        public Dog()
        {

        }

        public string DogIntroduction()
        {
            return String.Format("Mitt namn är {0}. Jag är en {1} år gammal {2}", Name, Age, Breed);
        }

    }
}
