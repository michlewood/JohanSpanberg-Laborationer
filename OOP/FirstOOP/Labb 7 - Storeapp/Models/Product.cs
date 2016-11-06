using Labb_7___Storeapp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7___Storeapp.Wares
{
    abstract class Product : ISellable
    {
        public int Price
        { get; set; }

        public string Manufacturer
        { get; set; }

        public string ModelName
        { get; set; }

        public string ProductInformation
        { get; set; }

        public bool Bought
        { get; set; }
    }
}
