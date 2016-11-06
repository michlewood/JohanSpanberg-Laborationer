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
    class UserInterfaces
    {
        internal void MainMenu(ProductManagement productManagement, MyLists currentList)
        {
            Console.WriteLine("What do you want:");
            Console.WriteLine("1. Show products");
            Console.WriteLine("2. Add product");
            Console.WriteLine("3. Remove Product");
            Console.WriteLine("4. Handle shopping cart");

            var input = Console.ReadKey(true).Key;

            switch (input)
            {
                case ConsoleKey.D1:
                    productManagement.ShowCurrentWares(currentList);
                    Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                    productManagement.AddWare(currentList);
                    break;

                case ConsoleKey.D3:
                    productManagement.ShowCurrentWares(currentList);
                    productManagement.RemoveWare(currentList);
                    Console.ReadLine();
                    break;

                case ConsoleKey.D4:
                    productManagement.EditShoppingCart(currentList);
                    break;
                default:
                    Console.WriteLine("Not a valid input, try again.");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }
    }
}
