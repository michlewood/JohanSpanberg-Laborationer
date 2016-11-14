using Labb_10___Delegater_Repetition.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_10___Delegater_Repetition
{
    class BookManager
    {
        public List<Book> Books { get; set; }

        public BookManager()
        {
            Books = new List<Book>
        {
            new Book
            {
                Title = "Hunt for Red October",
                Genre = "Action",
                Pages = 361,
                Price = 199.99
            },
        new Book
            {
                Title = "Korv",
                Genre = "Mystery",
                Pages = 4,
                Price = 3000.99
            }
            };
        }

        public void PrintWhere(BookFilter filter)
        {
            foreach (var book in Books)
            {
                if (filter(book))
                    Console.WriteLine(book.Title);
            }
        }
    }
}
