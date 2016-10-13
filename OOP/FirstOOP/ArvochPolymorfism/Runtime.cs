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

        static List<Animal> allAnimals = new List<Animal>();

        static List<Mammal> mammals = new List<Mammal>();
        static List<Reptile> reptiles = new List<Reptile>();
        static List<Bird> birds = new List<Bird>();

        static List<Dog> dogs = new List<Dog>();
        static List<Snake> snakes = new List<Snake>();
        static List<Eagle> eagles = new List<Eagle>();


        public void Start()
        {
            Menus.MainMenu();
        }

        public static void EditMenu()
        {
            Menus.optionalChoice = "\t\t┃                                                  ┃";
            bool loop = false;
            do
            {
                Menus.EditMenuGUI();

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D:
                        {
                            AnimalAdder(input);
                            loop = true;
                            break;
                        }

                    case ConsoleKey.R:
                        {
                            AnimalAdder(input);
                            loop = true;
                            break;
                        }
                    case ConsoleKey.F:
                        {
                            AnimalAdder(input);
                            loop = true;
                            break;
                        }
                    case ConsoleKey.G: loop = false; break;
                    default:
                        {
                            Console.WriteLine("Använd bara D, R, F eller G.");
                            loop = true;
                            Console.ReadLine();
                            break;
                        }
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
                mammals.Add(new Mammal
                {
                    AnimalType = typeWhenAddingNewAnimal,
                    AnimalName = nameWhenAddingNewAnimal,
                    Age = ageWhenAddingNewAnimal,
                    NumberOfLegs = numberOfLegsWhenAddingNewAnimal,
                    Height = heightWhenAddingNewAnimal,
                    FurLength = furLength,
                    CanRun = runSpeed,
                    Sound = soundWhenAddingNewAnimal
                });

            }
            else if (input == ConsoleKey.R)
            {
                Console.WriteLine("--- Reptil ---");
                AnimalAddingQuestions();
                Console.Write("Skinömsningsfrekvens per år: ");
                int skinShredding = int.Parse(Console.ReadLine());
                reptiles.Add(new Reptile
                {
                    AnimalType = typeWhenAddingNewAnimal,
                    AnimalName = nameWhenAddingNewAnimal,
                    Age = ageWhenAddingNewAnimal,
                    NumberOfLegs = numberOfLegsWhenAddingNewAnimal,
                    Height = heightWhenAddingNewAnimal,
                    SkinShredding = skinShredding,
                    Sound = soundWhenAddingNewAnimal
                });

            }
            else if (input == ConsoleKey.F)
            {
                Console.WriteLine("--- Fågel ---");
                AnimalAddingQuestions();
                Console.Write("Näbblängd i cm: ");
                int beakLength = int.Parse(Console.ReadLine());
                birds.Add(new Bird
                {
                    AnimalType = typeWhenAddingNewAnimal,
                    AnimalName = nameWhenAddingNewAnimal,
                    Age = ageWhenAddingNewAnimal,
                    NumberOfLegs = numberOfLegsWhenAddingNewAnimal,
                    Height = heightWhenAddingNewAnimal,
                    BeakSize = beakLength,
                    Sound = soundWhenAddingNewAnimal
                });

            }
        }
        public static void AnimalShower()
        {
            AnimalUpdater();
            Menus.optionalChoice = "\t\t┃      (V)isa alla dina djur.                      ┃";
            bool loop = false;
            do
            {
                Menus.EditMenuGUI();

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D:
                        {
                            int i = 1;
                            foreach (var mammal in mammals)
                            {
                                Console.WriteLine("{0}. {1}", i, mammal.Presentation());
                                i++;
                            }

                            Console.ReadLine();
                        }
                        loop = true; break;
                    case ConsoleKey.R:
                        {
                            int i = 1;
                            foreach (var reptile in reptiles)
                            {
                                Console.WriteLine("{0}. {1}", i, reptile.Presentation());
                                i++;
                            }

                            Console.ReadLine();
                        }
                        loop = true; break;
                    case ConsoleKey.F:
                        {
                            int i = 1;
                            foreach (var bird in birds)
                            {
                                Console.WriteLine("{0}. {1}", i, bird.Presentation());
                                i++;
                            }

                            Console.ReadLine();
                        }
                        loop = true; break;
                    case ConsoleKey.V:
                        {
                            int i = 1;
                            foreach (var animal in allAnimals)
                            {
                                Console.WriteLine("{0}. {1}", i, animal.Presentation());
                                i++;
                            }

                            Console.ReadLine();
                        }
                        loop = true; break;
                    case ConsoleKey.G: loop = false; break;
                    default:
                        {
                            Console.WriteLine("Använd bara D, R, F, V eller G.");
                            loop = true;
                            Console.ReadLine();
                            break;
                        }
                }

            } while (loop);

        }
        public static void AnimalRemover()
        {
            Menus.optionalChoice = "\t\t┃                                                  ┃";
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

                            Console.WriteLine("Vilket djur vill du ta bort?");
                            int removalChoice = int.Parse(Console.ReadLine());

                            mammals.RemoveAt(removalChoice - 1);
                            Console.WriteLine("Klart. Tog bort position {0}.", removalChoice);
                        }
                        loop = true;
                        break;
                    case ConsoleKey.R:
                        {
                            int i = 0;
                            foreach (var Reptile in reptiles)
                            {
                                Console.WriteLine("{0}. {1}", i, Reptile.Presentation());
                                i++;
                            }
                            Console.WriteLine("Vilket djur vill du ta bort?");
                            int removalChoice = int.Parse(Console.ReadLine());

                            reptiles.RemoveAt(removalChoice - 1);
                            Console.WriteLine("Klart. Tog bort position {0}.", removalChoice);
                        }
                        loop = true;
                        break;
                    case ConsoleKey.F:
                        {
                            int i = 0;
                            foreach (var Bird in birds)
                            {
                                Console.WriteLine("{0}. {1}", i, Bird.Presentation());
                                i++;
                            }
                            Console.WriteLine("Vilket djur vill du ta bort?");
                            int removalChoice = int.Parse(Console.ReadLine());

                            birds.RemoveAt(removalChoice - 1);
                            Console.WriteLine("Klart. Tog bort position {0}.", removalChoice);
                        }
                        loop = true;
                        break;
                    case ConsoleKey.G: loop = false; break;
                    default:
                        {
                            Console.WriteLine("Använd bara D, R, F eller G.");
                            loop = true;
                            Console.ReadLine();
                            break;
                        }
                }

            } while (loop);

        }
        static void AnimalUpdater()
        {
            allAnimals.Clear();
            allAnimals.AddRange(mammals);
            allAnimals.AddRange(reptiles);
            allAnimals.AddRange(birds);
        }
    }
}
