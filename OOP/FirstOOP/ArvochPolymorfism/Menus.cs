using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvochPolymorfism
{
    class Menus
    {
        public void MainMenu()
        {

            bool loop = false;
            Console.Clear();
            do
            {
                Console.WriteLine("\t\t┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                Console.WriteLine("\t\t┃                Vad vill du göra?                ┃");
                Console.WriteLine("\t\t┣━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┫");
                Console.WriteLine("\t\t┃      (L)ägg till djur                           ┃");
                Console.WriteLine("\t\t┃      (T)a bort djur                             ┃");
                Console.WriteLine("\t\t┃      (V)isa listor                              ┃");
                Console.WriteLine("\t\t┃      (S)täng programmet.                        ┃");
                Console.WriteLine("\t\t┃      (Välj genom att använda L, T, V och S)     ┃");
                Console.WriteLine("\t\t┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.L: loop = true; break;
                    case ConsoleKey.T: loop = true; break;
                    case ConsoleKey.V: Console.Clear(); loop = true; break;
                    case ConsoleKey.S: Environment.Exit(0); break;
                    default: Console.WriteLine("Använd bara L, T, V eller S."); loop = true; Console.ReadLine(); Console.Clear(); break;
                }

            } while (loop);

        }
        public void EditMenu()
        {

            bool loop = false;
            Console.Clear();
            do
            {
                Console.WriteLine("\t\t┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                Console.WriteLine("\t\t┃                Vad vill du göra?                ┃");
                Console.WriteLine("\t\t┣━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┫");
                Console.WriteLine("\t\t┃      Lägg till (D)äggdjur                       ┃");
                Console.WriteLine("\t\t┃      Lägg till (R)eptil                         ┃");
                Console.WriteLine("\t\t┃      Lägg till (F)ågel                          ┃");
                Console.WriteLine("\t\t┃      (G)å tillbaka till huvudmenyn.             ┃");
                Console.WriteLine("\t\t┃      (Välj genom att använda D, R, F och G)     ┃");
                Console.WriteLine("\t\t┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D: loop = true; break;
                    case ConsoleKey.R: loop = true; break;
                    case ConsoleKey.F: Console.Clear(); loop = true; break;
                    case ConsoleKey.G: loop = false; break;
                    default: Console.WriteLine("Använd bara L, T, V eller S."); loop = true; Console.ReadLine(); Console.Clear(); break;
                }

            } while (loop);

        }
    }
}
