using Labb_8___Delegater_VG.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_8___Delegater_VG
{
    class Graphics
    {
        public static void MainMenu(ProductManager productManager)
        {
            ProductManager.StringConcatinator formattedStrings = (List<Product> products) =>
            {
                string result = "";

                for (int i = 0; i < products.Count; i++)
                {
                    result = result + products[i].Name + ", ";
                }

                return result;
            };

            ProductManager.NumberOperator showAllProductPrices = (List<Product> products) =>
            {
                float result = 0;
                    for (int i = 0; i < products.Count; i++)
                    {
                        result = result + products[i].Price;
                    }
                    result = result * 1.2F;

                    return result;
            };
            ProductManager.NumberOperator showAllPricesOverThousand = (List<Product> products) =>
            {
                float result = 0;
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].Price > 1000)
                    {
                        result = result + products[i].Price;
                    }

                    result = result * 0.9F;
                }
                return result;
            };


            bool mainMenuLoop = true;
            while (mainMenuLoop)
            {
                Console.Clear();
                Console.WriteLine("1. List products.");
                Console.WriteLine("2. Add 20%.");
                Console.WriteLine("3. Remove 10% from $1000 products.");
                Console.WriteLine("4. End.");
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        productManager.FormatProductNames(formattedStrings);
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D2:
                        productManager.PriceCalculation(showAllProductPrices);
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D3:
                        productManager.PriceCalculation(showAllPricesOverThousand);
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Not a valid input.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
