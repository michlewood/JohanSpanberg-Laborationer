using Labb_5___My_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5___My_Repository.DataStores.Repositories
{
    interface IRepository
    {
        Game[] GetGames();
        Show[] GetShows();

        void AddGame(Game newGame);
        void RemoveGame(Game game);

        void AddShow(Show newShow);
        void RemoveShow(Show show);
    }
}
