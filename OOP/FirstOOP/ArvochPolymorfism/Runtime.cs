using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvochPolymorfism
{
    class Runtime
    {
        static string typeWhenAddingNewAnimal;
        static string nameWhenAddingNewAnimal;
        static int ageWhenAddingNewAnimal;
        static int numberOfLegsWhenAddingNewAnimal;
        static int weightWhenAddingNewAnimal;
        static int heightWhenAddingNewAnimal;
        static string soundWhenAddingNewAnimal;

        public static string variableMenuShower { get; set; }

        static List<Mammal> mammals = new List<Mammal>();
        static List<Reptile> reptiles = new List<Reptile>();
        static List<Bird> birds = new List<Bird>();



        public void Start()
        {
            Menus.MainMenu();
        }

        public static void EditMenu()
        {

            bool loop = false;
            Console.Clear();
            do
            {
                Menus.EditMenuGUI();

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D: AnimalAdder(input); loop = true; break;
                    case ConsoleKey.R: AnimalAdder(input); loop = true; break;
                    case ConsoleKey.F: AnimalAdder(input); loop = true; break;
                    case ConsoleKey.G: loop = false; break;
                    default: Console.WriteLine("Använd bara L, T, V eller S."); loop = true; Console.ReadLine(); Console.Clear(); break;
                }

            } while (loop);

        }
        static void AnimalAddingQuestions()
        {
            Console.Write("Ange djurras: ");
            typeWhenAddingNewAnimal = Console.ReadLine();
            Console.Write("Djurets namn: ");
            nameWhenAddingNewAnimal = Console.ReadLine();
            Console.Write("Beskriv djurets läte med ett ord: ");
            soundWhenAddingNewAnimal = Console.ReadLine();
            Console.Write("Ange åldern: ");
            ageWhenAddingNewAnimal = int.Parse(Console.ReadLine());
            Console.Write("Ange antal ben: ");
            numberOfLegsWhenAddingNewAnimal = int.Parse(Console.ReadLine());
            Console.Write("Ange vikt: ");
            weightWhenAddingNewAnimal = int.Parse(Console.ReadLine());
            Console.Write("Ange höjd/längd: ");
            heightWhenAddingNewAnimal = int.Parse(Console.ReadLine());
        }

        public static void AnimalAdder(ConsoleKey input)
        {
            if (input == ConsoleKey.D)
            {
                Console.WriteLine("--- Däggdjur ---");
                AnimalAddingQuestions();
                Console.Write("Ange pälslängd: ");
                int furLength = int.Parse(Console.ReadLine());
                Console.Write("Ange springhastighet: ");
                int runSpeed = int.Parse(Console.ReadLine());
                mammals.Add(new Mammal { AnimalType = typeWhenAddingNewAnimal, AnimalName = nameWhenAddingNewAnimal, Age = ageWhenAddingNewAnimal, NumberOfLegs = numberOfLegsWhenAddingNewAnimal, Weight = weightWhenAddingNewAnimal, Height = heightWhenAddingNewAnimal, FurLength = furLength, CanRun = runSpeed, Sound = soundWhenAddingNewAnimal });

            }
            else if (input == ConsoleKey.R)
            {
                Console.WriteLine("--- Reptil ---");
                AnimalAddingQuestions();
                Console.Write("Skinömsningsfrekvens per år: ");
                int skinShredding = int.Parse(Console.ReadLine());
                reptiles.Add(new Reptile { AnimalType = typeWhenAddingNewAnimal, AnimalName = nameWhenAddingNewAnimal, Age = ageWhenAddingNewAnimal, NumberOfLegs = numberOfLegsWhenAddingNewAnimal, Weight = weightWhenAddingNewAnimal, Height = heightWhenAddingNewAnimal, SkinShredding = skinShredding, Sound = soundWhenAddingNewAnimal });

            }
            else if (input == ConsoleKey.F)
            {
                Console.WriteLine("--- Fågel ---");
                AnimalAddingQuestions();
                Console.Write("Näbblängd i cm: ");
                int beakLength = int.Parse(Console.ReadLine());
                birds.Add(new Bird { AnimalType = typeWhenAddingNewAnimal, AnimalName = nameWhenAddingNewAnimal, Age = ageWhenAddingNewAnimal, NumberOfLegs = numberOfLegsWhenAddingNewAnimal, Weight = weightWhenAddingNewAnimal, Height = heightWhenAddingNewAnimal, BeakSize = beakLength, Sound = soundWhenAddingNewAnimal });

            }
        }
        public static void AnimalShower()
        {

            bool loop = false;
            Console.Clear();
            do
            {
                Menus.EditMenuGUI();

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D:
                        {
                            int i = 0;
                            foreach (var Mammal in mammals)
                            {
                                Console.WriteLine("{0}. {1}", i, Mammal.Presentation());
                                i++;
                            }

                            Console.ReadLine();
                        }
                        loop = true; break;
                    case ConsoleKey.R:
                        {
                            int i = 0;
                            foreach (var Reptile in reptiles)
                            {
                                Console.WriteLine("{0}. {1}", i, Reptile.Presentation());
                                i++;
                            }

                            Console.ReadLine();
                        }
                        loop = true; break;
                    case ConsoleKey.F:
                        {
                            int i = 0;
                            foreach (var Bird in birds)
                            {
                                Console.WriteLine("{0}. {1}", i, Bird.Presentation());
                                i++;
                            }

                            Console.ReadLine();
                        }
                        loop = true; break;
                    case ConsoleKey.G: loop = false; break;
                    default: Console.WriteLine("Använd bara L, T, V eller S."); loop = true; Console.ReadLine(); Console.Clear(); break;
                }

            } while (loop);

        }
        public static void AnimalRemover()
        {

            bool loop = false;
            Console.Clear();
            do
            {
                Menus.EditMenuGUI();

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D: AnimalAdder(input); loop = true; break;
                    case ConsoleKey.R: AnimalAdder(input); loop = true; break;
                    case ConsoleKey.F: AnimalAdder(input); loop = true; break;
                    case ConsoleKey.G: loop = false; break;
                    default: Console.WriteLine("Använd bara L, T, V eller S."); loop = true; Console.ReadLine(); Console.Clear(); break;
                }

            } while (loop);

        }
    }
}
