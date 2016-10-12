using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetConsoleApp
{
    class Menus
    {
        static void MainMenu()
        {
            bool loop = false;
            do
            {
                Console.WriteLine("Vad vill du göra?");
                Console.WriteLine("1. Lägg till hund");
                Console.WriteLine("2. Ta bort hund");
                Console.WriteLine("3. Visa hundar");
                Console.WriteLine("4. Stäng programmet.");

                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.L: break;
                    case ConsoleKey.T: break;
                    case ConsoleKey.V: break;
                    case ConsoleKey.S: break;
                    default: Console.WriteLine("Använd bara L, T, V eller S."); break;

                }
            } while (loop);



        }

        static void DogAdder()
        {

        }
        static void DogRemover()
        {

        }
        static void DogShower()
        {

        }
    }
}
