using Labb_8___Delegater_VG.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_8___Delegater_VG
{
    class ProductManager
    {
        public static List<Product> products = new List<Product>
        {
            new Product{ Name = "KorvEtt", ID = 1, Price = 900.25F},
            new Product{ Name = "KorvTvå", ID = 2, Price = 1050.1F},
            new Product{ Name = "KorvTre", ID = 3, Price = 431.1F},
            new Product{ Name = "KorvFyr", ID = 4, Price = 1500.1F}
        };

        public delegate float NumberOperator(List<Product> products);
        public delegate string StringConcatinator(List<Product> products);

        public void FormatProductNames(StringConcatinator formattedStrings)
        {
            Console.WriteLine(formattedStrings(products));
        }

        public void PriceCalculation(NumberOperator inputFromMainMenuChoice)
        {
            Console.WriteLine("${0}", inputFromMainMenuChoice(products));
        }
    }
}
