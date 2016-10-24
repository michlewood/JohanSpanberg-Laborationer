using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_5___Controllers.Models;

namespace Workshop_5___Controllers
{
    class UI
    {
        public static void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Add game");
            Console.WriteLine("2. Remove game");
            Console.WriteLine("3. Show all games");
            Console.WriteLine("4. Edit game");
            Console.WriteLine("5. Exit");
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

        public static void EditGame(Game game)
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

        public static int SelectGame(Game[] games)
        {
            PrintGameList(games);
            Console.Write("Select Game: ");
            return int.Parse(Console.ReadLine());

        }

        public static void PrintGameGenres()
        {

            foreach (var genre in Enum.GetValues(typeof(Game.GenreType)))
            {
                Console.WriteLine("{0}, {1}", (int)genre, genre);
            }
        }

        public static void PrintGameList(Game[] games)
        {
            Console.Clear();
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
