using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3___Biljettbokning
{
    class Runtime
    {
        public static Event[] availableSubset;

        public static string UserName { get; set; }

        private static string showTypeChooser;

        public static string ShowTypeChooser
        {
            get { return showTypeChooser; }
            set { showTypeChooser = value; }
        }

        public void GetUserInformation()
        {
            TicketManager manager = new TicketManager();

            Console.WriteLine("Ditt namn: ");
            UserName = Console.ReadLine();

            var menu = new MenuGUI();
            menu.MainMenu();
        }

        public static void ListAvailableSorter()
        {
            TicketManager.ListCombiner();
            Console.Clear();

            if (ShowTypeChooser == "Film" || ShowTypeChooser == "Konsert" || ShowTypeChooser == "Festival")
            {
                availableSubset = Code.Lists.events
                                    .Where(tickets => tickets.Type.Equals(ShowTypeChooser))
                                    .ToArray();
            }

            else
            {
                availableSubset = Code.Lists.events.ToArray();
            }

            int index = 0;

            foreach (var entry in availableSubset)
            {
                index++;
                Console.WriteLine("{0}. {1}", index, entry.Presentation());
            }

            MenuGUI.BookingQuestioneer();
        }
    }
}
