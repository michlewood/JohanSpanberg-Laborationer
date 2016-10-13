using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetConsoleApp
{
    class Runtime
    {
        List<Dog> dogs = new List<Dog>()

            {
                new Dog { Name = "Per", Age = 14, Breed = "Dobermann" },
                new Dog { Name = "Cissi", Age = 11, Breed = "Schäfer" },
                new Dog { Name = "Cera", Age = 3, Breed = "Amerikansk Bulldog" },
                new Dog { Name = "Lisa", Age = 7, Breed = "Tax" },
                new Dog { Name = "Jacko", Age = 12, Breed = "Bichon Frisé" },
            };

        public void DogShower()
        {
            int i = 0;
            foreach (var dog in dogs)
            {
                i++;
                Console.WriteLine(i + ". " + dog.DogIntroduction());
            }
            AfterInfo();
        }

        public void DogAdder()
        {
            Console.Clear();
            Dog newDog = new Dog();
            Console.WriteLine("Hundens namn: ");
            newDog.Name = Console.ReadLine();
            Console.WriteLine("Hundens ålder: ");
            newDog.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Hundens ras: ");
            newDog.Breed = Console.ReadLine();

            dogs.Add(newDog);
            Console.WriteLine("Lägger till {0}, {1}, {2}", newDog.Name, newDog.Age, newDog.Breed);
            AfterInfo();
            Console.Clear();
        }

        public void DogRemover()
        {
            DogShower();

            Console.WriteLine("Vilken hund vill du ta bort?");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Tar bort {0}", input);

            dogs.RemoveAt(input -1);

            AfterInfo();

            Console.Clear();
        }
        public void AfterInfo()
        {
            Console.WriteLine("Tryck enter för att gå vidare.");
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
