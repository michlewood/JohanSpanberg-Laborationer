using Labb_5___My_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5___My_Repository.DataStores.Repositories
{
    class ListRepository : IRepository
    {
        public void AddGame(Game newGame)
        {
            MyLists.Games.Add(newGame);
        }

        public void AddShow(Show newShow)
        {
            MyLists.Shows.Add(newShow);
        }

        public Game[] GetGames()
        {
            return MyLists.Games.ToArray();
        }

        public Show[] GetShows()
        {
            return MyLists.Shows.ToArray();
        }

        public void RemoveGame(Game game)
        {
            MyLists.Games.Remove(game);
        }

        public void RemoveShow(Show show)
        {
            MyLists.Shows.Remove(show);
        }
    }
}
