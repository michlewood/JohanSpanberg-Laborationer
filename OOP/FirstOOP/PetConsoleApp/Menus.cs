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

                Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                Console.WriteLine("┃                Vad vill du göra?                ┃");
                Console.WriteLine("┣━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┫");
                Console.WriteLine("┃      (L)ägg till hund                           ┃");
                Console.WriteLine("┃      (T)a bort hund                             ┃");
                Console.WriteLine("┃      (V)isa hundar                              ┃");
                Console.WriteLine("┃      (S)täng programmet.                        ┃");
                Console.WriteLine("┃      (Välj genom att använda L, T, V och S)     ┃");
                Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

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
