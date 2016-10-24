using Labb_5___My_Repository.DataStores.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5___My_Repository.Controllers
{
    class TVShowController
    {
        private IRepository showRepository = new ListRepository();

        public void CreateShow()
        {
            var newShow = UI.CreateShow();
            showRepository.AddShow(newShow);
        }

        public void RemoveShow()
        {
            var shows = showRepository.GetShows();
            var index = UI.SelectShow(shows) - 1;
            showRepository.RemoveShow(shows[index]);
        }

        public void PrintShowList()
        {
            Console.Clear();
            UI.PrintShowList(showRepository.GetShows());
            Console.ReadKey(true);
        }

        internal void EditShow()
        {
            var shows = showRepository.GetShows();
            //UI.PrintShowList(shows);
            int index = UI.SelectShow(shows);

            UI.EditShow(shows[index]);
        }
    }
}
