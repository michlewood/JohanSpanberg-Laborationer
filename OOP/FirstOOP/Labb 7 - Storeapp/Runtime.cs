using Labb_7___Storeapp.DataStores;
using Labb_7___Storeapp.Other_Classes;
using Labb_7___Storeapp.Wares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7___Storeapp
{
    class Runtime
    {
        internal void Start()
        {
            var userInterface = new UserInterfaces();
            var currentList = new MyLists();
            var productManagement = new ProductManagement(currentList);

            while (true)
            {
                userInterface.MainMenu(productManagement, currentList);
            }
        }
    }
}
