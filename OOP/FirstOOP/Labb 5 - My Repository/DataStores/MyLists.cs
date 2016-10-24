using Labb_5___My_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5___My_Repository.DataStores
{
    class MyLists
    {
        private static List<Game> games;
        private static List<Show> shows;

        public static List<Game> Games
        {
            get
            {
                if (games == null)
                    games = new List<Game>();

                return games;

            }
        }
        public static List<Show> Shows
        {
            get
            {
                if (shows == null)
                    shows = new List<Show>();

                return shows;

            }
        }
    }
}
