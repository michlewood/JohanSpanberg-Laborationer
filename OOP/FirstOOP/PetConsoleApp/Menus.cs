using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetConsoleApp
{
    class Menus
    {
        public static void MainMenu()
        {
            bool loop = false;
            Console.Clear();
            do
            {
                
                Console.WriteLine("Vad vill du göra?");
                Console.WriteLine("(L)ägg till hund");
                Console.WriteLine("(T)a bort hund");
                Console.WriteLine("(V)isa hundar");
                Console.WriteLine("(S)täng programmet.");

                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.L: Runtime.DogAdder(); loop = true; break;
                    case ConsoleKey.T: Runtime.DogRemover(); loop = true; break;
                    case ConsoleKey.V: Runtime.DogShower(); loop = true; break;
                    case ConsoleKey.S: Environment.Exit(0); break;
                    default: Console.WriteLine("Använd bara L, T, V eller S."); loop = true; break;

                }
            } while (loop);
        }
    }
}
