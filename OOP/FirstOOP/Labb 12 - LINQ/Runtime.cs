using Labb_12___LINQ.Managers;
using System;

namespace Labb_12___LINQ
{
    internal class Runtime
    {
        MovieManager manager = new MovieManager();

        internal void Start()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Get movie with a specific title");
                Console.WriteLine("2. Get all movies in a genre");
                Console.WriteLine("3. Get all movies shorter than 120 minutes");
                Console.WriteLine("4. Make/Show a string array with all names");
                Console.WriteLine("5. Save a specific movie to a string");
                Console.WriteLine("6. Starting with T, specific genre, longer than 120 minutes");
                Console.WriteLine("7. Quit");

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        manager.SearchNameOrGenre(true);
                        break;
                    case ConsoleKey.D2:
                        manager.SearchNameOrGenre(false);
                        break;
                    case ConsoleKey.D3:
                        manager.ShorterThanOneHundredAndTwentyMinutesLong();
                        break;
                    case ConsoleKey.D4:
                        manager.CreateStringArray();
                        break;
                    case ConsoleKey.D5:
                        manager.SpecificMovieToString();
                        break;
                    case ConsoleKey.D6:
                        manager.StartingWithTSpecificGenreLongerThanOneHundredAndTwentyMinutesLong();
                        break;
                    case ConsoleKey.D7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Not a valid choice.");
                        Console.ReadKey();
                        break;
                }
            }

        }
    }
}