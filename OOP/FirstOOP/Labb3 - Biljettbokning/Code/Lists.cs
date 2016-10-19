using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3___Biljettbokning.Code
{
    class Lists
    {
        public static List<Event> events = new List<Event>()
        {

        };

        public static List<AvailableConcerts> concert = new List<AvailableConcerts>()
        {
            new AvailableConcerts
            {
                Artist = "Roxette",
                Alcohole = false,
                Date = 3,
                Location = "Globen",
                Name = "Farewell",
                Price = 299,
                Type = "Konsert",
                IsBooked = false
            },

            new AvailableConcerts
            {
                Artist = "Abba",
                Alcohole = true,
                Date = 6,
                Location = "Tele2 Arena",
                Name = "Status",
                Price = 849,
                Type = "Konsert",
                IsBooked = false
            }
        };

        public static List<AvailableFestivals> festivals = new List<AvailableFestivals>()
        {
            new AvailableFestivals
            {
                Alcohole = true,
                Date = 11,
                Location = "Globen",
                Name = "Mixed Temple",
                Price = 1699,
                Bands = "Farrell, Status Quo, Eva Longoria, Justin Bieber",
                Type = "Festival",
                IsBooked = false
            },

            new AvailableFestivals
            {
                Alcohole = true,
                Date = 28,
                Location = "Tele2 Arena",
                Name = "Modded Psytrance",
                Price = 849,
                Bands = "Techno Kings, Knife Party, Infected Mushrooms, Nitro Fun",
                Type = "Festival",
                IsBooked = false
            }
        };

        public static List<AvailableMovies> movies = new List<AvailableMovies>()
        {
            new AvailableMovies
            {
                Date = 4,
                Location = "Filmstaden, Kista",
                Name = "Die Hard 5",
                Price = 129,
                RRated = true,
                Stars = "Bruce Willis, Keanue Reeves, Reese Witherspoon",
                Type = "Film",
                IsBooked = false
            },

            new AvailableMovies
            {
                Date = 14,
                Location = "Saga Biografen, Härnösand",
                Name = "Up 2",
                Price = 79,
                RRated = false,
                Stars = "Jim Carrey, Arnold Schwarzenegger",
                Type = "Film",
                IsBooked = false
            }
        };
    }
}
