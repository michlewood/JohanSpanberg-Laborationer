using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvochPolymorfism3
{
    class Runtime
    {
        public void Start()
        {
            AnimalManager manager = new AnimalManager();

            bool loop = true;

            while(loop)
            {
                Console.Clear();
                Menus.PrintMainMenu();

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        manager.AddAnimal();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        manager.RemoveAnimal();
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        manager.ShowAnimals();

                        break;
                }
            }
        }
    }
}
