using Labb_10___Delegater_Repetition.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_10___Delegater_Repetition.Filters
{
    class BookFilters
    {
        public static bool IsNovel(Book book)
        {
            return book.Pages > 100;
        }
        public static bool IsShortStory(Book book)
        {
            return book.Pages < 10;
        }
        public static bool IsGenreMystery(Book book)
        {
            return book.Genre == "Mystery";
        }
        public static bool IsGenreAction(Book book)
        {
            return book.Genre == "Action";
        }
        public static bool IsGenreRomance(Book book)
        {
            return book.Genre == "Romance";
        }
        public static bool IsCheap(Book book)
        {
            return book.Price < 200;
        }
        public static bool IsExpensive(Book book)
        {
            return book.Price > 200;
        }
    }
}
