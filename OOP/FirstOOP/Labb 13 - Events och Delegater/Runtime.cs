using Labb_13___Events_och_Delegater.Filters;
using Labb_13___Events_och_Delegater.Managers;
using Labb_13___Events_och_Delegater.Models;
using System;

namespace Labb_13___Events_och_Delegater
{
    
    internal class Runtime
    {
        private event PrintMessage WrongInput;

        ItemFilter isCheapFilter = ItemFilters.IsCheap;
        ItemFilter isOldFilter = ItemFilters.IsOld;
        ItemFilter isFreshFilter = ItemFilters.IsFresh;


        public void Start()
        {
            ItemManager manager = new ItemManager();

            WrongInput += new PrintMessage(WrongInputErrorMessage);

            while (true)
            {
                Console.Clear();
                UserMenus.MainMenu();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        FilterMethod(manager);
                        break;

                    case ConsoleKey.D2:
                        manager.AddNewProduct(this);
                        break;

                    case ConsoleKey.D3:
                        Environment.Exit(0);
                        break;

                    default: OnWrongInput("Not a valid input.");
                        break;
                }

            } 
        }

        private void FilterMethod(ItemManager manager)
        {
            bool showProductLoop = true;
            Console.Clear();

            manager.ShowAllProducts();

            Console.WriteLine("---");

            while (showProductLoop)
            {
                UserMenus.FilterMenu();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        manager.PrintWhere(isCheapFilter);
                        break;
                    case ConsoleKey.D2:
                        manager.PrintWhere(isOldFilter);
                        break;
                    case ConsoleKey.D3:
                        manager.PrintWhere(isFreshFilter);
                        break;
                    case ConsoleKey.D4:
                        showProductLoop = false;
                        break;
                    default:
                        OnWrongInput("Not a valid input.");
                        break;
                }

            }
        }
        public void OnWrongInput(string message)
        {
            WrongInput?.Invoke(message);
        }
        public void WrongInputErrorMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}