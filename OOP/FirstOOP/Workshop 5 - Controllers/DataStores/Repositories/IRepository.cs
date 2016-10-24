using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_5___Controllers.Models;

namespace Workshop_5___Controllers.DataStores.Repositories
{
    interface IRepository
    {
        Game[] GetGames();
        void AddGame(Game newGame);
        void RemoveGame(Game game);
    }
}
