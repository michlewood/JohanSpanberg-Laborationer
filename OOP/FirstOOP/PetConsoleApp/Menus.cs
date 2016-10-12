using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetConsoleApp
{
    class Menus
    {
        public void MainMenu()
        {
            Runtime runtime = new Runtime();
            bool loop = false;
            Console.Clear();
            do
            {

                Console.WriteLine("\t\t┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                Console.WriteLine("\t\t┃                Vad vill du göra?                ┃");
                Console.WriteLine("\t\t┣━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┫");
                Console.WriteLine("\t\t┃      (L)ägg till hund                           ┃");
                Console.WriteLine("\t\t┃      (T)a bort hund                             ┃");
                Console.WriteLine("\t\t┃      (V)isa hundar                              ┃");
                Console.WriteLine("\t\t┃      (S)täng programmet.                        ┃");
                Console.WriteLine("\t\t┃      (Välj genom att använda L, T, V och S)     ┃");
                Console.WriteLine("\t\t┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.L: runtime.DogAdder(); loop = true; break;
                    case ConsoleKey.T: runtime.DogRemover(); loop = true; break;
                    case ConsoleKey.V: runtime.DogShower(); Console.Clear(); loop = true; break;
                    case ConsoleKey.S: Environment.Exit(0); break;
                    default: Console.WriteLine("Använd bara L, T, V eller S."); loop = true; Console.ReadLine(); Console.Clear(); break;
                }
            } while (loop);
        }
    }
}
