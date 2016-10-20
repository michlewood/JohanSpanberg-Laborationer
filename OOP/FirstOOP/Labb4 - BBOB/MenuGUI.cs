using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4___BBOB
{
    class MenuGUI
    {
        internal static void MainMenu(Lists lists)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Bildatabasen");
                Console.WriteLine("Vad vill du göra");
                Console.WriteLine("1. Visa lagersaldo");
                Console.WriteLine("2. Lägg till fordon.");
                Console.WriteLine("3. Avsluta");
                Console.WriteLine("---");
                Console.WriteLine("Just nu {0} fordon i lager.", Runtime.TotalInStock);

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        ShowStockMenu(lists);
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        AddCarMenu(lists);
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Du kan enbart använda 1, 2 eller 3.");
                        Console.WriteLine("(Tryck enter för att återgå och försöka igen)");
                        Console.ReadLine();
                        break;
                }
            }
        }
        
        private static void ShowStockMenu(Lists lists)
        {
            bool showStockMenuLoop = true;
            while (showStockMenuLoop)
            {
                Console.Clear();
                Console.WriteLine("Bildatabasen");
                Console.WriteLine("Vad vill du göra");
                Console.WriteLine("1. Visa nya fordon ({0} fordon)", lists.NewVehicle.Count());
                Console.WriteLine("2. Visa begagnade fordon ({0} fordon)", lists.UsedVehicle.Count());
                Console.WriteLine("3. Visa alla fordon ({0} fordon)", lists.TotalStock.Count());
                Console.WriteLine("4. Återgå till huvudmenyn");
                Console.WriteLine("---");
                Console.WriteLine("Just nu {0} fordon i lager.", lists.TotalStock.Count());

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        lists.ShowNewStockMenu();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        lists.ShowUsedStockMenu();
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        lists.ShowTotalStockMenu();
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        showStockMenuLoop = false;
                        break;

                    default:
                        Console.WriteLine("Du kan enbart använda 1, 2 eller 3.");
                        Console.WriteLine("(Tryck enter för att återgå och försöka igen)");
                        Console.ReadLine();
                        break;
                }
            }
        }

        private static void AddCarMenu(Lists lists)
        {
            
            bool addCarMenuLoop = true;
            while (addCarMenuLoop)
            {
                Console.Clear();
                Console.WriteLine("Bildatabasen");
                lists.SimplePresentation();
                Console.WriteLine("---");
                Console.WriteLine("Finns bilen redan i databasen?");
                Console.WriteLine("J - Lägg till i saldo");
                Console.WriteLine("N - Lägg till nytt fordon.");
                Console.WriteLine("A - Avbryt.");

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.J:
                        lists.ListAddToExistingVehicle();
                        break;

                    case ConsoleKey.N:
                        lists.ListAddNewVehicle();
                        break;

                    case ConsoleKey.A:
                        addCarMenuLoop = false; 
                        break;

                    default:
                        Console.WriteLine("Du kan enbart använda J, N eller A.");
                        Console.WriteLine("(Tryck enter för att återgå och försöka igen)");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
