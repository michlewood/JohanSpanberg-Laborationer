using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetConsoleApp
{
    class Runtime
    {
        static List<Dog> dogs = new List<Dog>()

            {
                new Dog { Name = "Per", Age = 14, Breed = "Dobermann" },
                new Dog { Name = "Cissi", Age = 11, Breed = "Schäfer" },
                new Dog { Name = "Cera", Age = 3, Breed = "Amerikansk Bulldog" },
                new Dog { Name = "Lisa", Age = 7, Breed = "Tax" },
                new Dog { Name = "Jacko", Age = 12, Breed = "Bichon Frisé" },
            };

        public static void DogShower()
        {
            int i = 0;
            foreach (var dog in dogs)
            {
                i++;
                Console.WriteLine(i + ". " + dog.DogIntroduction());
            }
            Console.ReadLine();
        }

        public static void DogAdder()
        {
            Console.WriteLine("Hundens namn: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hundens ålder: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Hundens ras: ");
            string breed = Console.ReadLine();

            dogs.Add(new Dog(name, age, breed));
            Console.WriteLine("Lägger till {0}, {1} och {2}", name, age, breed);

        }
        public static void DogRemover()
        {

        }
    }
}
