using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4___BBOB.Economic
{
    class BuyingSellingMethods
    {

        internal void CarBuyer(Economy economy, Lists lists)
        { // Denna kod är enkel och har grundläggande funktion bara för att visa funktionaliteten i programmet.
          // Det måste till mycket mer kod för att fungera med egentillagda bilar.
            int userInputInCarBuyer = 0;
            int amountToBuy = 0;

            bool carBuyerControlLoop = true;
            while (carBuyerControlLoop)
            {
                Console.Clear();
                lists.SimpleForSalePresentation();
                Console.WriteLine("Vilket fordon vill du köpa fler av?");
                Console.WriteLine("Tryck på 0 för att återgå till huvudmenyn.");
                Console.WriteLine("---");
                Console.WriteLine("Du har {0} kronor", economy.TotalAmountOfCash);
                userInputInCarBuyer = int.Parse(Console.ReadLine());

                if (userInputInCarBuyer == 0)
                {
                    carBuyerControlLoop = false;
                    return;
                }

                else if (userInputInCarBuyer == 1)
                {
                    Console.WriteLine("Hur många {0} {1} skulle du vilja köpa?", (lists.ForSaleNewVehicle[0].Manufacturer), (lists.ForSaleNewVehicle[0].Manufacturer));
                    amountToBuy = int.Parse(Console.ReadLine());

                    if (amountToBuy * lists.ForSaleNewVehicle[0].Price > economy.TotalAmountOfCash)
                    {
                        Console.WriteLine("Du har inte råd. Försök med ett mindre antal.");
                        Console.ReadLine();
                        return;
                    }
                    else
                        carBuyerControlLoop = false;
                }
                else if (userInputInCarBuyer == 2)
                {
                    Console.WriteLine("Hur många {0} {1} skulle du vilja köpa?", (lists.ForSaleUsedVehicle[0].Manufacturer), (lists.ForSaleUsedVehicle[0].Manufacturer));
                    amountToBuy = int.Parse(Console.ReadLine());

                    if (amountToBuy * lists.ForSaleUsedVehicle[0].Price > economy.TotalAmountOfCash)
                    {
                        Console.WriteLine("Du har inte råd. Försök med ett mindre antal.");
                        Console.ReadLine();
                        return;
                    }
                    else
                        carBuyerControlLoop = false;
                }
                else if (userInputInCarBuyer == 3)
                {
                    Console.WriteLine("Hur många {0} {1} skulle du vilja köpa?", (lists.ForSaleNewVehicle[1].Manufacturer), (lists.ForSaleNewVehicle[1].Manufacturer));
                    amountToBuy = int.Parse(Console.ReadLine());

                    if (amountToBuy * lists.ForSaleNewVehicle[1].Price > economy.TotalAmountOfCash)
                    {
                        Console.WriteLine("Du har inte råd. Försök med ett mindre antal.");
                        Console.ReadLine();
                        return;
                    }
                    else
                        carBuyerControlLoop = false;
                }
                else
                {
                    Console.WriteLine("Använd bara 1, 2, 3 eller A");
                    return;
                }
            }
            if (userInputInCarBuyer == 1)
            {
                economy.TotalAmountOfCash = economy.TotalAmountOfCash - (lists.ForSaleNewVehicle[0].Price * amountToBuy);
                lists.NewVehicle[0].Amount = lists.NewVehicle[0].Amount + amountToBuy;
                lists.ForSaleNewVehicle[0].Amount = lists.ForSaleNewVehicle[0].Amount - amountToBuy;
                Console.WriteLine("Klart. Du har nu {0} kronor kvar.", economy.TotalAmountOfCash);
            }
            else if (userInputInCarBuyer == 2)
            {
                economy.TotalAmountOfCash = economy.TotalAmountOfCash - (lists.ForSaleUsedVehicle[0].Price * amountToBuy);
                lists.UsedVehicle[0].Amount = lists.UsedVehicle[0].Amount + amountToBuy;
                lists.ForSaleUsedVehicle[0].Amount = lists.ForSaleUsedVehicle[0].Amount - amountToBuy;
                Console.WriteLine("Klart. Du har nu {0} kronor kvar.", economy.TotalAmountOfCash);
            }
            else if (userInputInCarBuyer == 3)
            {
                economy.TotalAmountOfCash = economy.TotalAmountOfCash - (lists.ForSaleNewVehicle[1].Price * amountToBuy);
                lists.NewVehicle[1].Amount = lists.NewVehicle[1].Amount + amountToBuy;
                lists.ForSaleNewVehicle[1].Amount = lists.ForSaleNewVehicle[1].Amount - amountToBuy;
                Console.WriteLine("Klart. Du har nu {0} kronor kvar.", economy.TotalAmountOfCash);
            }
            Console.ReadLine();
            lists.ListUpdater();
            carBuyerControlLoop = false;
        }

        internal void CarSeller(Economy economy, Lists lists)
        { 
            bool keepInStock = false;
            bool newVehicle = false;
            bool stockLeft = false;
            string vehicleForSaleManufacturer = "";
            string vehicleForSaleModel = "";
            int vehicleForSalePrice = 0;
            int vehicleForSaleAmount = 0;
            int userInputInForsale = 0;

            {
                bool carSellerTotalLoop = true;
                while (carSellerTotalLoop)
                {
                    bool carSellerControlLoop = true;
                    while (carSellerControlLoop)
                    {
                        Console.Clear();
                        lists.SimplePresentation();
                        Console.WriteLine("Vilket fordon vill du sälja?");
                        Console.WriteLine("Tryck på 0 för att återgå till huvudmenyn.");
                        userInputInForsale = int.Parse(Console.ReadLine());
                        if (userInputInForsale == 0)
                        {
                            carSellerControlLoop = false;
                            carSellerTotalLoop = false;
                            return;
                        }

                        if (lists.TotalStock[userInputInForsale - 1]
                                            .GetType()
                                            .BaseType
                                            .ToString() == "Labb4___BBOB.StockUsed"
                                            && userInputInForsale >= lists.NewVehicle.Count
                                            && lists.UsedVehicle[userInputInForsale - lists.NewVehicle.Count() - 1].Amount == 0)
                        {
                            Console.WriteLine("Du har inga fler {0} {1} att sälja. Försök med ett annat fordon.", (lists.UsedVehicle[userInputInForsale - lists.NewVehicle.Count() - 1].Manufacturer), (lists.UsedVehicle[userInputInForsale - lists.NewVehicle.Count() - 1].Model));
                            Console.WriteLine("Tryck på enter för att gå tillbaka och välja ett annat fordon.");
                            Console.ReadLine();
                        }

                        else if (lists.TotalStock[userInputInForsale - 1]
                                            .GetType()
                                            .BaseType
                                            .ToString() == "Labb4___BBOB.StockNew"
                                            && lists.NewVehicle[userInputInForsale - 1].Amount == 0)
                        {
                            Console.WriteLine("Du har inga fler {0} {1} att sälja.", (lists.NewVehicle[userInputInForsale - 1].Manufacturer), (lists.NewVehicle[userInputInForsale - 1].Manufacturer));
                            Console.WriteLine("Tryck på enter för att gå tillbaka och välja ett annat fordon.");
                            Console.ReadLine();

                        }

                        else
                        {
                            carSellerControlLoop = false;
                        }
                    }
                    Console.WriteLine("Hur många vill du sälja ur lagret?");
                    int amountForSale = int.Parse(Console.ReadLine());


                    if (lists.TotalStock[userInputInForsale - 1]
                                    .GetType()
                                    .BaseType
                                    .ToString() == "Labb4___BBOB.StockUsed")
                    {
                        newVehicle = false;
                        if (amountForSale >= (lists.UsedVehicle[userInputInForsale - lists.NewVehicle.Count() - 1].Amount))
                        {
                            vehicleForSaleManufacturer = (lists.UsedVehicle[userInputInForsale - lists.NewVehicle.Count() - 1].Manufacturer);
                            vehicleForSaleModel = (lists.UsedVehicle[userInputInForsale - lists.NewVehicle.Count() - 1].Model);
                            vehicleForSalePrice = (lists.UsedVehicle[userInputInForsale - lists.NewVehicle.Count() - 1].Price);
                            vehicleForSaleAmount = (lists.UsedVehicle[userInputInForsale - lists.NewVehicle.Count() - 1].Amount);

                            Console.WriteLine("Vill du sälja alla tillgängliga och ta bort {0} {1} efter försäljning? (J/N)", (lists.UsedVehicle[userInputInForsale - lists.NewVehicle.Count() - 1].Manufacturer), (lists.UsedVehicle[userInputInForsale - lists.NewVehicle.Count() - 1].Model));
                            var input = Console.ReadKey(true).Key;

                            switch (input)
                            {
                                case ConsoleKey.J:
                                    Console.WriteLine("Okej. Om du accepterar budet kommer {0} {1} att försvinna efter försäljning.", (lists.UsedVehicle[userInputInForsale - lists.NewVehicle.Count() - 1].Manufacturer), (lists.UsedVehicle[userInputInForsale - lists.NewVehicle.Count() - 1].Model));
                                    amountForSale = vehicleForSaleAmount;
                                    keepInStock = false;

                                    break;

                                case ConsoleKey.N:
                                    Console.WriteLine("Okej. Om du accepterar budet så kommer {0} {1} att finnas kvar efter försäljning.", (lists.UsedVehicle[userInputInForsale - lists.NewVehicle.Count() - 1].Manufacturer), (lists.UsedVehicle[userInputInForsale - lists.NewVehicle.Count() - 1].Model));
                                    amountForSale = vehicleForSaleAmount;
                                    keepInStock = true;

                                    break;
                                default: Console.WriteLine("Använd enbart J eller N."); break;
                            }
                        }
                        else
                        {
                            stockLeft = true;
                        }
                    }
                    else
                    {
                        vehicleForSaleManufacturer = (lists.NewVehicle[userInputInForsale - 1].Manufacturer);
                        vehicleForSaleModel = (lists.NewVehicle[userInputInForsale - 1].Model);
                        vehicleForSalePrice = (lists.NewVehicle[userInputInForsale - 1].Price);
                        vehicleForSaleAmount = (lists.NewVehicle[userInputInForsale - 1].Amount);
                        newVehicle = true;

                        if (amountForSale >= vehicleForSaleAmount)
                        {
                            Console.WriteLine("Vill du sälja alla tillgängliga och ta bort {0} {1} efter försäljning? (J/N)", (lists.NewVehicle[userInputInForsale - 1].Manufacturer), (lists.NewVehicle[userInputInForsale - 1].Model));
                            var input = Console.ReadKey(true).Key;

                            switch (input)
                            {
                                case ConsoleKey.J:
                                    Console.WriteLine("Okej. Om du accepterar budet kommer {0} {1} att försvinna efter försäljning.", (lists.NewVehicle[userInputInForsale - 1].Manufacturer), (lists.NewVehicle[userInputInForsale - 1].Model));
                                    amountForSale = vehicleForSaleAmount;
                                    keepInStock = false;

                                    break;

                                case ConsoleKey.N:
                                    Console.WriteLine("Okej. Om du accepterar budet så kommer {0} {1} att finnas kvar efter försäljning.", (lists.NewVehicle[userInputInForsale - 1].Manufacturer), (lists.NewVehicle[userInputInForsale - 1].Model));
                                    amountForSale = vehicleForSaleAmount;
                                    keepInStock = true;
                                    break;
                                default: Console.WriteLine("Använd enbart J eller N."); break;
                            }
                        }
                        else
                        {
                            stockLeft = true;

                        }
                    }
                    double currentBid = economy.RandomizedBid(0.8, 1.3) * vehicleForSalePrice;
                    int currentBidInt = (int)(currentBid * 100);
                    currentBid = (double)currentBidInt;
                    currentBid = currentBid / 100;
                    int numberOfOffers = economy.RandomizedNumberOfOffers(1, amountForSale);
                    int buyPriceTotal = vehicleForSalePrice * numberOfOffers;
                    decimal korv = (decimal) currentBid;

                    //Console.WriteLine("Earnings this week: " + string.Format("{0:0.00}", answer));

                    Console.Clear();
                    Console.WriteLine("Du har fått ett bud!");
                    Console.WriteLine("Köparen vill köpa {3} stycken {0} {1} för {2} kronor.", vehicleForSaleManufacturer, vehicleForSaleModel, korv * numberOfOffers, numberOfOffers);
                    Console.WriteLine("Inköpspriset var {0} kronor.", buyPriceTotal);
                    if (vehicleForSalePrice >= currentBid)
                    {
                        Console.WriteLine("Detta skulle innebära en förlust på {0} kronor.", currentBid - vehicleForSalePrice);
                    }
                    else
                    {
                        Console.WriteLine("Detta skulle innebära en vinst på {0} kronor.", currentBid - vehicleForSalePrice);
                    }

                    Console.WriteLine("Vill du acceptera? (J/N)");

                    var acceptBidInput = Console.ReadKey(true).Key;

                    switch (acceptBidInput)
                    {
                        case ConsoleKey.J:
                            economy.TotalAmountOfCash += (currentBid * numberOfOffers);

                            if (numberOfOffers < amountForSale)
                            {
                                if (newVehicle)
                                {
                                    lists.NewVehicle[userInputInForsale - 1].Amount = lists.NewVehicle[userInputInForsale - 1].Amount - numberOfOffers;
                                }
                                else
                                {
                                    lists.UsedVehicle[userInputInForsale - lists.NewVehicle.Count() - 1].Amount = lists.UsedVehicle[userInputInForsale - lists.NewVehicle.Count() - 1].Amount - numberOfOffers;
                                }
                            }

                            else
                            {
                                if (newVehicle && keepInStock && !stockLeft)
                                {
                                    lists.NewVehicle[userInputInForsale - 1].Amount = 0;
                                }

                                else if (!newVehicle && keepInStock && !stockLeft)
                                {
                                    lists.UsedVehicle[userInputInForsale - lists.NewVehicle.Count() - 1].Amount = 0;
                                }

                                else if (newVehicle && !keepInStock && !stockLeft)
                                {
                                    lists.NewVehicle.RemoveAt(userInputInForsale - 1);
                                }

                                else if (!newVehicle && !keepInStock && !stockLeft)
                                {
                                    lists.UsedVehicle.RemoveAt(userInputInForsale - lists.NewVehicle.Count() - 1);
                                }

                                else if (newVehicle && stockLeft)
                                {
                                    lists.NewVehicle[userInputInForsale - 1].Amount = lists.NewVehicle[userInputInForsale - 1].Amount - numberOfOffers;
                                }

                                else if (!newVehicle && stockLeft)
                                {
                                    lists.UsedVehicle[userInputInForsale - lists.NewVehicle.Count() - 1].Amount = lists.UsedVehicle[userInputInForsale - lists.NewVehicle.Count() - 1].Amount - numberOfOffers;
                                }

                            }


                            Console.WriteLine("Grattis. Du har nu {0} kronor att röra dig med.",
                                                economy.TotalAmountOfCash);
                            carSellerTotalLoop = false;
                            lists.ListUpdater();
                            Console.WriteLine("Tryck på Enter för att fortsätta.");
                            Console.ReadLine();
                            return;

                        case ConsoleKey.N:
                            Console.WriteLine("Nekar erbjudandet och återgår till försäljningsmenyn.");
                            Console.ReadLine();
                            carSellerTotalLoop = false;
                            lists.ListUpdater();
                            Console.WriteLine("Tryck på Enter för att fortsätta.");
                            Console.ReadLine();
                            return;
                        default: break;
                    }
                    

                }
            }
        }
    }
}
