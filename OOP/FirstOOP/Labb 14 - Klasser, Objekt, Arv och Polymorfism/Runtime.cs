using Labb_14___Klasser__Objekt__Arv_och_Polymorfism;
using Labb_14___Klasser__Objekt__Arv_och_Polymorfism.DataStores;
using System;
using System.Linq;

namespace Labb_14___Klasser__Objekt__Arv_och_Polymorfism
{
    internal class Runtime
    {
        internal void Start()
        {
            MyLists myLists = new MyLists();

            while (true)
            {
                Console.Clear();
                Console.Write("Search for author: ");
                string input = Console.ReadLine();

                var searchResultsInBooks = myLists.Books.Where(author => author.Author.Name == input);
                var searchResultsInPapers = myLists.Papers.Where(author => author.Author.Name == input);
                var searchResultsInMagazines = myLists.Magazines.Where(author => author.Author.Name == input);

                Console.WriteLine("\nBooks by {0}", input);
                foreach (var item in searchResultsInBooks)
                {
                    Console.Write("{0} - {1} pages. {2}. Released: ", item.Title, item.Pages, item.Genre);
                    Console.Write(String.Format("{0:yyyy/MM/dd} ", item.ReleaseDate)); 
                    Console.WriteLine("by {0}", item.Author.Name);
                }
                if (!searchResultsInBooks.Any())
                {
                    Console.WriteLine("No results for {0} in Books.", input);
                }


                Console.WriteLine("\nPapers by {0}", input);
                foreach (var item in searchResultsInPapers)
                {
                    Console.Write("{0} - Released: ", item.Title);
                    Console.Write(String.Format("{0:yyyy/MM/dd} ", item.ReleaseDate));
                    Console.WriteLine("by {0}", item.Author.Name);  
                }
                if (!searchResultsInPapers.Any())
                {
                    Console.WriteLine("No results for {0} in Papers.", input);
                }

                Console.WriteLine("\nMagazines by {0}", input);
                foreach (var item in searchResultsInMagazines)
                {
                    Console.Write("{0} - Released: ", item.Title);
                    Console.Write(String.Format("{0:yyyy/MM/dd} ", item.ReleaseDate));
                    Console.WriteLine("by {0}", item.Author.Name);
                }
                if (!searchResultsInMagazines.Any())
                {
                    Console.WriteLine("No results for {0} in Magazines.", input);
                }
                Console.ReadLine();


            }
        }
    }
}