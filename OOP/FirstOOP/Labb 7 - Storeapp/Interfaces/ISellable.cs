using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7___Storeapp.Interfaces
{
    interface ISellable
    {
        int Price { get; set; }
        string ProductInformation { get; set; }

    }
}
