﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3___Biljettbokning
{
    class MenuGUI
    {
        private static bool removeMenuLoop;

        public static bool RemoveMenuLoop
        {
            get { return removeMenuLoop; }
            set { removeMenuLoop = value; }
        }


        public void MainMenu()
        {
            var manager = new TicketManager();
            bool menuLoop = true;
            while (menuLoop)
            {
                Console.Clear();
                Console.WriteLine("Välkommen till TicketLocker {0}.", Runtime.UserName);
                Console.WriteLine("1. Visa Events");
                Console.WriteLine("2. Visa Bokningar");
                Console.WriteLine("3. Avsluta programmet.");

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        AvailableEventsSorted();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        manager.ShowBookings();
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        public void AvailableEventsSorted()
        {
            var manager = new TicketManager();
            bool menuLoop = true;
            while (menuLoop)
            {
                Console.Clear();
                Console.WriteLine("Välkommen till TicketLocker {0}.", Runtime.UserName);
                Console.WriteLine("1. Visa Filmer");
                Console.WriteLine("2. Visa Konserter");
                Console.WriteLine("3. Visa Festival");
                Console.WriteLine("4. Visa Alla");
                Console.WriteLine("5. Gå tillbaka till huvudmenyn");

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Runtime.ShowTypeChooser = "Film";
                        Runtime.ListAvailableSorter();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Runtime.ShowTypeChooser = "Konsert";
                        Runtime.ListAvailableSorter();
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Runtime.ShowTypeChooser = "Festival";
                        Runtime.ListAvailableSorter();
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Runtime.ShowTypeChooser = "Else";
                        Runtime.ListAvailableSorter();
                        break;

                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        menuLoop = false;
                        break;
                }
            }
        }

        public static void BookingQuestioneer()
        {
            var manager = new TicketManager();
            bool menuLoop = true;
            while (menuLoop)
            {

                Console.WriteLine();
                Console.WriteLine("---");
                Console.WriteLine("Skulle du vilja boka ett event {0}? (j/n)", Runtime.UserName);

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.J:
                        Console.WriteLine("---");
                        manager.AddBooking();
                        menuLoop = false;
                        break;

                    case ConsoleKey.N:
                        menuLoop = false;
                        break;

                    default:
                        Console.WriteLine("Du måste använda J eller N.");
                        Console.WriteLine("Tryck på enter för att försöka igen.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        public static void RemoveBookedEvent()
        {
            var manager = new TicketManager();
            RemoveMenuLoop = true;
            while (RemoveMenuLoop)
            {
                Console.WriteLine();
                Console.WriteLine("---");
                Console.WriteLine("Skulle du vilja avboka ett event {0}? (j/n)", Runtime.UserName);

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.J:
                        Console.WriteLine("---");
                        manager.RemoveBooking();
                        RemoveMenuLoop = false;
                        break;

                    case ConsoleKey.N:
                        RemoveMenuLoop = false;
                        break;

                    default:
                        Console.WriteLine("Du måste använda J eller N.");
                        Console.WriteLine("Tryck på enter för att försöka igen.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
