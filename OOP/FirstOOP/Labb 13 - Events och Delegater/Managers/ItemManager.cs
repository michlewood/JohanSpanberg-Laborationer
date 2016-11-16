using Labb_13___Events_och_Delegater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_13___Events_och_Delegater.Managers
{
    class ItemManager
    {
        public List<Item> ItemList { get; set; }

        public ItemManager()
        {
            ItemList = new List<Item>
            {
                new Item { Name = "Korv", Age = 4, Worth = 20 },
                new Item { Name = "Banan", Age = 1, Worth = 10 },
                new Item { Name = "Mjölk", Age = 8, Worth = 12 },
                new Item { Name = "Tacokrydda", Age = 11, Worth = 15 },
                new Item { Name = "Stroganoff", Age = 5, Worth = 42 },
                new Item { Name = "Blodpudding", Age = 9, Worth = 19 },
                new Item { Name = "Palt", Age = 19, Worth = 24 },
                new Item { Name = "Krydda", Age = 7, Worth = 16 }
            };
        }

        public void PrintWhere(ItemFilter filter)
        {
            foreach (var item in ItemList)
            {
                if (filter(item))
                    Console.WriteLine("{0} - {1} days. {2} SEK", item.Name, item.Age, item.Worth);
            }
        }


        internal void ShowAllProducts()
        {
            foreach (var item in ItemList)
            {
                Console.WriteLine("{0} - {1} days. {2} SEK", item.Name, item.Age, item.Worth);
            }
        }

        internal void AddNewProduct(Runtime runtime)
        {
            int newAge = 0;
            int newWorth = 0;

            Console.Write("Enter product name: ");
            string newName = Console.ReadLine();
            Console.Write("Enter product Age: ");

            bool isAge = false;
            while (!isAge)
            {
                string input = Console.ReadLine();
                isAge = int.TryParse(input, out newAge);
                if (!isAge)
                {
                    runtime.OnWrongInput("Not a valid product age"); 
                    Console.Write("Enter product Age: ");
                }
                }
            
            Console.Write("Enter product Worth: ");

            bool isWorth = false;
            while (!isWorth)
            {
                string input = Console.ReadLine();
                isWorth = int.TryParse(input, out newWorth);
                if (!isWorth)
                {
                    runtime.OnWrongInput("Not a valid product worth."); 
                    Console.Write("Enter product Worth: ");
                }
            }

            ItemList.Add(new Item { Name = newName, Age = newAge, Worth = newWorth });
        }
    }
}
