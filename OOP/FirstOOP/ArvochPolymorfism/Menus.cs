using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvochPolymorfism
{
    class Menus
    {

        public static string optionalChoice = "\t\t┃                                                  ┃";

        public static void MainMenu()
        {

            bool loop = false;
            Console.Clear();
            do
            {
                Console.Clear();
                Console.WriteLine("\t\t┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                Console.WriteLine("\t\t┃                Vad vill du göra?                 ┃");
                Console.WriteLine("\t\t┣━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┫");
                Console.WriteLine("\t\t┃      (L)ägg till djur                            ┃");
                Console.WriteLine("\t\t┃      (T)a bort djur                              ┃");
                Console.WriteLine("\t\t┃      (V)isa listor                               ┃");
                Console.WriteLine("\t\t┃      (S)täng programmet.                         ┃");
                Console.WriteLine("\t\t┃      (Välj genom att använda L, T, V och S)      ┃");
                Console.WriteLine("\t\t┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.L: Runtime.variableMenuShower = "Lägg till "; Runtime.EditMenu(); loop = true; break;
                    case ConsoleKey.T: Runtime.variableMenuShower = "Radera ett"; Runtime.AnimalRemover(); loop = true; break;
                    case ConsoleKey.V: Runtime.variableMenuShower = "Visa dina "; Runtime.AnimalShower(); Console.Clear(); loop = true; break;
                    case ConsoleKey.S: Environment.Exit(0); break;
                    default: Console.WriteLine("Använd bara L, T, V eller S."); loop = true; Console.ReadLine(); Console.Clear(); break;
                }

            } while (loop);

        }
        public static void EditMenuGUI()
        {

            Console.WriteLine("\t\t┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine("\t\t┃                Vad vill du göra?                 ┃");
            Console.WriteLine("\t\t┣━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┫");
            Console.WriteLine("\t\t┃      {0} (D)äggdjur                       ┃", Runtime.variableMenuShower);
            Console.WriteLine("\t\t┃      {0} (R)eptil                         ┃", Runtime.variableMenuShower);
            Console.WriteLine("\t\t┃      {0} (F)ågel                          ┃", Runtime.variableMenuShower);
            Console.WriteLine(optionalChoice);
            Console.WriteLine("\t\t┃      (G)å tillbaka till huvudmenyn.              ┃");
            Console.WriteLine("\t\t┃      (Välj genom att använda D, R, F och G)      ┃");
            Console.WriteLine("\t\t┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
        }
    }
}
