using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetConsoleApp
{
    class Runtime
    {
        public void Start()
        {
            List<Dog> dogs = new List<Dog>()

            {
                new Dog { Name = "Per", Age = 14, Breed = "Dobermann" },
                new Dog { Name = "Cissi", Age = 11, Breed = "Schäfer" },
                new Dog { Name = "Cera", Age = 3, Breed = "Amerikansk Bulldog" },
                new Dog { Name = "Lisa", Age = 7, Breed = "Tax" },
                new Dog { Name = "Jacko", Age = 12, Breed = "Bichon Frisé" },
            };
            foreach (var dog in dogs)
            {
                Console.WriteLine(dog.DogIntroduction());
            }
            Console.ReadLine();
        }

    }
}
