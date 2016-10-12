using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvochPolymorfism
{
    class MenuFunctions

    {

        List<Animal> animals = new List<Animal>()

            {
            
            };

        public void AnimalShower()

        {
            int i = 0;
            //foreach (var dog in dogs)

            {
                i++;
                //Console.WriteLine(i + ". " + dog.DogIntroduction());
            }
            AfterInfo();
        }


        public void AnimalAdder()

        {

            Console.Clear();
            Console.WriteLine("Hundens namn: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hundens ålder: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hundens ras: ");
            string breed = Console.ReadLine();



            //dogs.Add(new Dog(name, age, breed));

            Console.WriteLine("Lägger till {0}, {1}, {2}", name, age, breed);
            AfterInfo();
            Console.Clear();

        }



        public void AnimalRemover()

        {

            AnimalShower();

            Console.WriteLine("Vilken hund vill du ta bort?");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("Tar bort {0}", input);

            input--;

            //dogs.RemoveAt(input);

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
