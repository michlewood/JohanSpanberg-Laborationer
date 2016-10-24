using Labb_5___My_Repository.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5___My_Repository
{
    class Client
    {
        internal void Start()
        {
            var games = new GamesController();
            var shows = new TVShowController();

            var loop = true;

            while (loop)
            {
                UI.PrintMainMenu();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        games.CreateGame();
                        break;

                    case ConsoleKey.D2:
                        games.RemoveGame();
                        break;

                    case ConsoleKey.D3:
                        games.PrintGameList();
                        break;

                    case ConsoleKey.D4:
                        games.EditGame();
                        break;

                    case ConsoleKey.D5:
                        shows.CreateShow();
                        break;

                    case ConsoleKey.D6:
                        shows.RemoveShow();
                        break;

                    case ConsoleKey.D7:
                        shows.PrintShowList();
                        break;

                    case ConsoleKey.D8:
                        shows.EditShow();
                        break;

                    case ConsoleKey.D9:
                        loop = false;
                        break;

                }
            }

        }
    }
}
