using Labb_7___Storeapp.DataStores;
using Labb_7___Storeapp.Interfaces;
using Labb_7___Storeapp.Wares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7___Storeapp.Other_Classes
{
    class ProductManagement
    {
        

        public string NewManufacturer { get; set; }
        public string NewModel { get; set; }
        public int NewPrice { get; set; }
        public string NewProductDescription { get; set; }


        public ProductManagement(MyLists currentList)
        {
            currentList.Products.Add(new Computers
            {
                Manufacturer = "Microsoft",
                ModelName = "Surface Pro 5",
                Price = 14999,
                Bought = false,
                ProductInformation = "The computer that can replace your tablet, desktop and laptop."
            });

            currentList.Products.Add(new CellPhones
            {
                Manufacturer = "Microsoft",
                ModelName = "Surface Phone Pro",
                Price = 7999,
                Bought = false,
                ProductInformation = "The phone that can replace your Surface Pro."
            });

            currentList.Products.Add(new Hifi
            {
                Manufacturer = "Sonos",
                ModelName = "Soundbar",
                Price = 3699,
                Bought = false,
                ProductInformation = "Big sound in a small package."
            });
        }

        internal void EditShoppingCart(MyLists currentList)
        {
            bool shoppingCartLoop = true;
            while (shoppingCartLoop)
            {
                Console.Clear();
                ShowCurrentWares(currentList);
                Console.WriteLine();
                Console.WriteLine("Which product would you like to add to the cart?");
                Console.WriteLine("Type 0 to check current cart.");
                int input = int.Parse(Console.ReadLine());
                input--;

                if (input == -1)
                {
                    ShowCurrentShoppingCart(currentList);
                }
                else if (input > currentList.Products.Count())
                {
                    Console.WriteLine("That product does not exist, try again.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("That product exists");
                    currentList.Products[input].Bought = true;
                    shoppingCartLoop = false;
                    Console.ReadLine();
                }
                    
            }
        }

        private void ShowCurrentShoppingCart(MyLists currentList)
        {
            Console.Clear();
            int i = 0;
            int boughtValue = 0;
            Console.WriteLine("---");
            foreach (var product in currentList.Products)
            {
                if (product.Bought == true)
                {
                    Console.WriteLine("{3}. {0} {1} - {2}", product.Manufacturer, product.ModelName, product.ProductInformation, i + 1);
                    boughtValue = boughtValue + product.Price;
                    i++;
                }
            }
            Console.WriteLine("---");
            Console.WriteLine("Current cart value is {0} SEK", boughtValue);
            Console.WriteLine("---");
            /*Console.WriteLine("Would you like to remove something (y/n)");
            string inputYesNo = Console.ReadLine().ToLower();

            if (inputYesNo == "y")
            {
                Console.WriteLine("Which item would you like to remove?");
                int inputWhatToRemove = int.Parse(Console.ReadLine());

                foreach (var product in currentList.Products)
                {
                    currentList.Products[inputWhatToRemove -1].Bought = false;
                    boughtValue = boughtValue - currentList.Products[inputWhatToRemove -1].Price;
                }

                //currentList.Products[inputWhatToRemove].Bought = false;
                //boughtValue = boughtValue - currentList.Products[inputWhatToRemove].Price;
                Console.WriteLine("Done.");
                Console.ReadLine();


            }*/

        }

        internal void RemoveWare(MyLists currentList)
        {
            Console.WriteLine("Which ware would you like to remove?");
            int input = int.Parse(Console.ReadLine());

            currentList.Products.RemoveAt(input - 1);

        }

        public ProductManagement()
        {
        }

        internal void ShowCurrentWares(MyLists currentList)
        {
            int i = 0;
            Console.WriteLine("---");
            foreach (var product in currentList.Products)
            {
                Console.WriteLine("{3}. {0} {1} - {2}", product.Manufacturer, product.ModelName, product.ProductInformation, i +1);
                Console.WriteLine("{0} SEK.", product.Price);
                i++;
            }
            Console.WriteLine("---");       
        }

        internal void AddWare(MyLists currentList)
        {
            Console.WriteLine("What type of product do you want to add?");
            Console.WriteLine("1. Computer");
            Console.WriteLine("2. Cellphone");
            Console.WriteLine("3. Hifi");
            Console.WriteLine("4. Return to main menu.");

            var input = Console.ReadKey(true).Key;

            bool addWareLoop = true;
            while (addWareLoop)
            {
                switch (input)
                {
                    case ConsoleKey.D1:
                        AddWareStepTwo(1, currentList);
                        addWareLoop = false;
                        break;
                    case ConsoleKey.D2:
                        AddWareStepTwo(2, currentList);
                        addWareLoop = false;
                        break;
                    case ConsoleKey.D3:
                        AddWareStepTwo(3, currentList);
                        addWareLoop = false;
                        break;
                    case ConsoleKey.D4:
                        addWareLoop = false;
                        break;
                    default:
                        Console.WriteLine("Not a valid choice. Try again.");
                        break;
                }
            }
        }

        private void AddWareStepTwo(int addType, MyLists currentList)
        {
            AddWareInformationGathering();

            if (addType == 1)
            {
                currentList.Products.Add(new Computers
                {
                    Manufacturer = NewManufacturer,
                    ModelName = NewModel,
                    Price = NewPrice,
                    ProductInformation = NewProductDescription,
                    Bought = false
                });
            }
            else if (addType == 2)
            {
                currentList.Products.Add(new CellPhones
                {
                    Manufacturer = NewManufacturer,
                    ModelName = NewModel,
                    Price = NewPrice,
                    ProductInformation = NewProductDescription,
                    Bought = false
                });
            }
            else if (addType == 3)
            {
                currentList.Products.Add(new Hifi
                {
                    Manufacturer = NewManufacturer,
                    ModelName = NewModel,
                    Price = NewPrice,
                    ProductInformation = NewProductDescription,
                    Bought = false
                });
            }

            Console.WriteLine("Done!");

        }

        private void AddWareInformationGathering()
        {
            Console.Write("Enter the name of the manufacturer: ");
            NewManufacturer = Console.ReadLine();
            Console.Write("Enter the name of the model: ");
            NewModel = Console.ReadLine();
            Console.Write("Enter the price of the product: ");
            NewPrice = int.Parse(Console.ReadLine());
            Console.Write("Enter the product description: ");
            NewProductDescription = Console.ReadLine();
        }
    }
}
