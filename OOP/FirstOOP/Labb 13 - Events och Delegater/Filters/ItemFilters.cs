using Labb_13___Events_och_Delegater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_13___Events_och_Delegater.Filters
{
    class ItemFilters
    {
        public static bool IsCheap(Item item)
        {
            return item.Worth < 12;
        }
        public static bool IsOld(Item item)
        {
            return item.Age > 4;
        }
        public static bool IsFresh(Item item)
        {
            return item.Age < 2;
        }

    }
}
