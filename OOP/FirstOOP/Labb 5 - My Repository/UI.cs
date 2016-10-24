using Labb_5___My_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5___My_Repository
{
    class UI
    {
        public static void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Add game");
            Console.WriteLine("2. Remove game");
            Console.WriteLine("3. Show all games");
            Console.WriteLine("4. Add show");
            Console.WriteLine("5. Remove show");
            Console.WriteLine("6. Show all show");
            Console.WriteLine("7. Exit");
        }

        public static Show CreateShow()
        {
            Show newShow = new Show();
            Console.Clear();
            Console.Write("Show name: ");
            newShow.Name = Console.ReadLine();

            Console.WriteLine("Show genre: ");
            PrintShowGenres();

            Console.Write("Choose a genre: ");
            int choice = int.Parse(Console.ReadLine());
            newShow.Genre = (Show.GenreType)choice;

            return newShow;
        }

        internal static void EditShow(Show show)
        {
            Console.Clear();
            Console.WriteLine("1. Change name");
            Console.WriteLine("2. Change genre");
            Console.Write("Choice: ");
            var choice = Console.ReadKey(true).Key;

            Console.Clear();
            Console.WriteLine("Game: {0}. Genre {1}", show.Name, show.Genre);

            switch (choice)
            {
                case ConsoleKey.D1:
                    Console.Write("New name: ");
                    show.Name = Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                    Console.Write("Genre list: ");
                    PrintShowGenres();
                    Console.WriteLine("New genre: ");
                    show.Genre = (Show.GenreType)int.Parse(Console.ReadLine());
                    break;
            }
        }

        internal static void EditGame(Game game)
        {
            Console.Clear();
            Console.WriteLine("1. Change name");
            Console.WriteLine("2. Change genre");
            Console.Write("Choice: ");
            var choice = Console.ReadKey(true).Key;

            Console.Clear();
            Console.WriteLine("Game: {0}. Genre {1}", game.Name, game.Genre);

            switch (choice)
            {
                case ConsoleKey.D1:
                    Console.Write("New name: ");
                    game.Name = Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                    Console.Write("Genre list: ");
                    PrintGameGenres();
                    Console.WriteLine("New genre: ");
                    game.Genre = (Game.GenreType)int.Parse(Console.ReadLine());
                    break;
            }
        }

        public static void PrintShowGenres()
        {

            foreach (var genre in Enum.GetValues(typeof(Show.GenreType)))
            {
                Console.WriteLine("{0}, {1}", (int)genre, genre);
            }
        }

        public static void PrintShowList(Show[] shows)
        {
            Console.Clear();
            foreach (var show in shows)
            {
                Console.WriteLine("{0}. Show: {1}, Genre: {2}",
                Array.IndexOf(shows, show) + 1,
                show.Name,
                show.Genre);
            }
        }

        public static int SelectShow(Show[] shows)
        {
            PrintShowList(shows);
            Console.Write("Select Show: ");
            return int.Parse(Console.ReadLine());
        }

        public static Game CreateGame()
        {
            Game newGame = new Game();
            Console.Clear();
            Console.Write("Game name: ");
            newGame.Name = Console.ReadLine();

            Console.WriteLine("Game genre: ");
            PrintGameGenres();

            Console.Write("Choose a genre: ");
            int choice = int.Parse(Console.ReadLine());
            newGame.Genre = (Game.GenreType)choice;

            return newGame;
        }

        public static int SelectGame(Game[] games)
        {
            PrintGameList(games);
            Console.Write("Select Game: ");
            return int.Parse(Console.ReadLine());

        }

        public static void PrintGameGenres()
        {
            Console.Clear();
            foreach (var genre in Enum.GetValues(typeof(Game.GenreType)))
            {
                Console.WriteLine("{0}, {1}", (int)genre, genre);
            }
        }

        public static void PrintGameList(Game[] games)
        {

            foreach (var game in games)
            {
                Console.WriteLine("{0}. Game: {1}, Genre: {2}",
                Array.IndexOf(games, game) + 1,
                game.Name,
                game.Genre);
            }
        }
    }
}
