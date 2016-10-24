using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_5___Controllers.Models;

namespace Workshop_5___Controllers.DataStores.Repositories
{
    class ListRepository : IRepository
    {
        public Game[] GetGames()
        {
            return MyLists.Games.ToArray();
        }

        public void AddGame(Game newGame)
        {
            MyLists.Games.Add(newGame);
        }

        public void RemoveGame(Game game)
        {
            MyLists.Games.Remove(game);
        }
    }
}
