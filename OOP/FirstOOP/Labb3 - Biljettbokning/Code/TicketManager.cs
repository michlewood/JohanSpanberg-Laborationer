using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3___Biljettbokning
{
    class TicketManager
    {
        public static Event[] bookedSubset;

        public void ShowBookings()
        {
            ListCombiner();
            Console.Clear();

            bookedSubset = Code.Lists.events
                .Where(tickets => tickets.IsBooked.Equals(true))
                .ToArray();

            if (bookedSubset.Length == 0)
            {
                
                Console.WriteLine("Inga bokningar funna. Du bokar genom att först visa tillgängliga events.");
                Console.WriteLine("(Tryck på enter för att återgå till huvudmenyn.)");
                MenuGUI.RemoveMenuLoop = false;
                Console.ReadLine();
                return;
            }

            else
            {
                int index = 0;
                foreach (var entry in bookedSubset)
                {
                    index++;
                    Console.WriteLine("{0}. Bokad av {1}: {2} ", index, Runtime.UserName, entry.Presentation());
                }

                MenuGUI.RemoveBookedEvent();
            }
        }

        public void AddBooking()
        {
            ListCombiner();
            Console.WriteLine("Vilket event skulle du vilja boka: ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("Bokat: {0}", Runtime.availableSubset[input - 1].Presentation());
            Runtime.availableSubset[input - 1].IsBooked = true;

            Console.WriteLine("(Tryck på enter för att återgå till huvudmenyn.)");
            Console.ReadLine();
        }

        public void RemoveBooking()
        {
            ListCombiner();
            Console.WriteLine("Vilket event skulle du vilja avboka: ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("Avbokat: {0}", bookedSubset[input - 1].Presentation());
            bookedSubset[input - 1].IsBooked = false;

            Console.WriteLine("(Tryck på enter för att återgå till huvudmenyn.)");
            Console.ReadLine();
        }

        public static void ListCombiner()
        {
            Code.Lists.events.Clear();
            Code.Lists.events.AddRange(Code.Lists.concert);
            Code.Lists.events.AddRange(Code.Lists.movies);
            Code.Lists.events.AddRange(Code.Lists.festivals);
        }
    }
}