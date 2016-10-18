using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3___Biljettbokning
{
    class TicketManager
    {
        public static Event[] subset;

        public void ShowBookings()
        {
            ListCombiner();
            Console.Clear();

            subset = Runtime.events
                .Where(tickets => tickets.IsBooked.Equals(true))
                .ToArray();

            if (subset.Length == 0)
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
                foreach (var entry in subset)
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

            Console.WriteLine("Bokat: {0}", Runtime.events[input - 1].Presentation());
            Runtime.events[input - 1].IsBooked = true;

            Console.WriteLine("(Tryck på enter för att återgå till huvudmenyn.)");
            Console.ReadLine();
        }

        public void RemoveBooking()
        {
            ListCombiner();
            Console.WriteLine("Vilket event skulle du vilja avboka: ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("Avbokat: {0}", subset[input - 1].Presentation());
            subset[input - 1].IsBooked = false;

            Console.WriteLine("(Tryck på enter för att återgå till huvudmenyn.)");
            Console.ReadLine();
        }



        public static void ListCombiner()
        {
            Runtime.events.Clear();
            Runtime.events.AddRange(Runtime.concert);
            Runtime.events.AddRange(Runtime.movies);
            Runtime.events.AddRange(Runtime.festivals);
        }
    }
}