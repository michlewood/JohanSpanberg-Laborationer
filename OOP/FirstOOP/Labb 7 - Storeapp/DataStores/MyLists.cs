using Labb_7___Storeapp.Wares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7___Storeapp.DataStores
{
    class MyLists
    {
        List<Product> products = new List<Product>();

        public List<Product> Products
        {
            get
            {
                return products;
            }

            set
            {
                products = value;
            }
        }
    }
}

