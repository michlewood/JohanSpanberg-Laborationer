using Labb_10___Delegater_Repetition.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_10___Delegater_Repetition
{
    class Runtime
    {
        internal void Start()
        {
            BookManager manager = new BookManager();

            BookFilter isNovel = BookFilters.IsNovel;
            BookFilter isShortStory = BookFilters.IsShortStory;
            BookFilter isGenreMystery = BookFilters.IsGenreMystery;
            BookFilter isGenreAction = BookFilters.IsGenreAction;
            BookFilter isGenreRomance = BookFilters.IsGenreRomance;
            BookFilter isCheap = BookFilters.IsCheap;
            BookFilter isExpensive = BookFilters.IsExpensive;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Is a novel.");
                Console.WriteLine("2. Is a shortstory.");
                Console.WriteLine("3. Is a Mystery.");
                Console.WriteLine("4. Is a Action.");
                Console.WriteLine("5. Is a Romance.");
                Console.WriteLine("6. Is cheap.");
                Console.WriteLine("7. Is expensive.");
                Console.WriteLine("8. Quit.");
                Console.WriteLine("\n---");
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        manager.PrintWhere(isNovel);
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D2:
                        manager.PrintWhere(isShortStory);
                        Console.ReadLine();
                        break;

                    case ConsoleKey.D3:
                        manager.PrintWhere(isGenreMystery);
                        Console.ReadLine();
                        break;

                    case ConsoleKey.D4:
                        manager.PrintWhere(isGenreAction);
                        Console.ReadLine();
                        break;

                    case ConsoleKey.D5:
                        manager.PrintWhere(isGenreRomance);
                        Console.ReadLine();
                        break;

                    case ConsoleKey.D6:
                        manager.PrintWhere(isCheap);
                        Console.ReadLine();
                        break;

                    case ConsoleKey.D7:
                        manager.PrintWhere(isExpensive);
                        Console.ReadLine();
                        break;

                    case ConsoleKey.D8:
                        Environment.Exit(0);
                        break;
                    default: Console.WriteLine("Not a valid input."); break;
                }
            }
        }
    }
}
