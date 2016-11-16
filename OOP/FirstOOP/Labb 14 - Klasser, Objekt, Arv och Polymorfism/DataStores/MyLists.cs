using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_14___Klasser__Objekt__Arv_och_Polymorfism.DataStores
{
    class MyLists
    {
        public List<Book> Books { get; set; }
        public List<Magazine> Magazines { get; set; }
        public List<Paper> Papers { get; set; }
        public List<Author> Authors { get; set; }

        public MyLists()
        {
            Authors = new List<Author>
            {
                new Author { Name = "Tom Clancy", Age = 55 },
                new Author { Name = "Michael Connelly", Age = 62 },
                new Author { Name = "Stephen King", Age = 77 }
            };


            Books = new List<Book>
            {
                new Book
                {
                    Title = "The Hunt for Red October",
                    Genre = "Action",
                    Author = Authors[0],
                    Pages = 238,
                    ReleaseDate = new DateTime(1994, 5, 11)
                },
              new Book
              {
                  Title = "Bosch",
                  Genre = "Thriller",
                  Author = Authors[1],
                  Pages = 313,
                  ReleaseDate = new DateTime(2017, 3, 13)
              },
              new Book
              {
                  Title = "Birds",
                  Genre = "Horror",
                  Author = Authors[2],
                  Pages = 455,
                  ReleaseDate = new DateTime(1981, 8, 11)
              }
            };

            Magazines = new List<Magazine> {
                new Magazine
                {
                    Title = "Aktuell Rapport",
                    Author = Authors[2],
                    ReleaseDate = 
                    new DateTime(2017, 1, 28)
                },
              new Magazine
              {
                  Title = "Fib Aktuellt",
                  Author = Authors[1],
                  ReleaseDate = 
                  new DateTime(2006, 2, 28)
              },
              new Magazine
              {
                  Title = "PC Gamer",
                  Author = Authors[0],
                  ReleaseDate = new DateTime(2004, 6, 21)
              }
            };

            Papers = new List<Paper> {
                new Paper
                {
                    Title = "Expressen",
                    Author = Authors[1],
                    ReleaseDate = new DateTime(2011, 7, 4)
                },
            new Paper
            {
                Title = "Aftonbladet",
                Author = Authors[1],
                ReleaseDate = new DateTime(1999, 11, 21)
            },
            new Paper
            {
                Title = "Tidningen Ångermanland",
                Author = Authors[0],
                ReleaseDate = new DateTime(2004, 12, 24)
            }
            };
        }
    }
}
