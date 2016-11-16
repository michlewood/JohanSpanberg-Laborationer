using Labb_12___LINQ.DataStore;
using Labb_12___LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_12___LINQ.Managers
{
    class MovieManager
    {
        public List<Movie> Movies { get; set; }

        public MovieManager()
        {
            Movies = new List<Movie>
        {
            new Movie
            {
                Title = "The Hunt for Red October",
                Genre = "Action",
                Length = 86
            },

            new Movie
            {
                Title = "The Schindlers List",
                Genre = "Drama",
                Length = 195
            },

            new Movie
            {
                Title = "Fäbodjäntan",
                Genre = "Porr",
                Length = 116
            },

            new Movie
            {
                Title = "Die Hard",
                Genre = "Action",
                Length = 131
            },

            new Movie
            {
                Title = "The Sum of All Fears",
                Genre = "Action",
                Length = 124
            },

            new Movie
            {
                Title = "Ridskolan",
                Genre = "Porr",
                Length = 73
            }
        };
        }


        internal void SearchNameOrGenre(bool outputChoice)
        {
            var searchResults = Movies.Where(movie => movie.Title == "");
            Console.Write("Search for ");

            if (outputChoice)
            {
                Console.Write("title: ");
                var input = Console.ReadLine();
                searchResults = Movies.Where(movie => movie.Title == input);
            }
            else
            {
                Console.Write("genre: ");
                var input = Console.ReadLine();
                searchResults = Movies.Where(movie => movie.Genre == input);
            }

            foreach (var individualMovie in searchResults)
            {
                Console.WriteLine("{0} - {1}. {2} Minutes.", individualMovie.Title, individualMovie.Genre, individualMovie.Length);
            }
            Console.ReadLine();
        }

        internal void ShorterThanOneHundredAndTwentyMinutesLong()
        {
            var searchResults = Movies.Where(movie => movie.Length < 120);
        
            foreach (var individualMovie in searchResults)
            {
                Console.WriteLine("{0} - {1}. {2} Minutes.", individualMovie.Title, individualMovie.Genre, individualMovie.Length);
            }
            Console.ReadLine();
        }

        internal void CreateStringArray()
        {
            Movie[] searchResults = Movies
                .Where(movie => movie.Title.Length > 0)
                .ToArray();
            string[] savedArray = new string[searchResults.Length];

            for (int i = 0; i < searchResults.Length; i++)
            {
                savedArray[i] = searchResults[i].Title;
            }

            for (int i = 0; i < savedArray.Length; i++)
            {
                Console.WriteLine(savedArray[i]);
            }
            
            Console.ReadLine();
        }

        internal void SpecificMovieToString()
        {
            Console.Write("Search for title: ");
            var input = Console.ReadLine();
            var searchResults = Movies.Where(movie => movie.Title == input);
            string savedMovie = "";

            foreach (var movie in searchResults)
            {
                savedMovie = movie.Title;
            }

            Console.WriteLine("Done. Saved {0} to a string.", savedMovie);
            Console.ReadLine();
        }

        internal void StartingWithTSpecificGenreLongerThanOneHundredAndTwentyMinutesLong()
        {
            Console.Write("Which genre: ");
            string input = Console.ReadLine();

            var searchResults = Movies.Where(movie => movie.Title[0].ToString().Equals("T") && movie.Genre == input && movie.Length > 120);

            foreach (var movie in searchResults)
            {
                Console.WriteLine("{0}. {1} - {2} minutes", movie.Title, movie.Genre, movie.Length);
            }

            Console.ReadLine();
        }
    }
}
