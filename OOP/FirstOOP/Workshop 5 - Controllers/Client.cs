using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_5___Controllers.Controllers;

namespace Workshop_5___Controllers
{
    class Client
    {
        internal void Start()
        {
            var games = new GamesController();
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
                        loop = false;
                        break;

                }
            }
        }
    }
}
