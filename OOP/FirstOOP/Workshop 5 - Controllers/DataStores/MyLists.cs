using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_5___Controllers.Models;

namespace Workshop_5___Controllers.DataStores
{
    class MyLists
    {
        private static List<Game> games;

        public static List<Game> Games
        {
            get
            {
                if (games == null)
                    games = new List<Game>();

                return games;

            }
        }
    }
}
