using Labb_5___My_Repository.DataStores.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5___My_Repository.Controllers
{
    class GamesController
    {
        private IRepository gameRepository = new ListRepository();

        public void CreateGame()
        {
            var newGame = UI.CreateGame();
            gameRepository.AddGame(newGame);
        }

        public void RemoveGame()
        {
            var games = gameRepository.GetGames();
            var index = UI.SelectGame(games) - 1;
            gameRepository.RemoveGame(games[index]);
        }

        public void PrintGameList()
        {
            Console.Clear();
            UI.PrintGameList(gameRepository.GetGames());
            Console.ReadKey(true);
        }

        internal void EditGame()
        {
            var games = gameRepository.GetGames();
            //UI.PrintGameList(games);
            int index = UI.SelectGame(games);

            UI.EditGame(games[index]);
        }
    }


}
