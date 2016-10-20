using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4___BBOB
{
    class Lists
    {
        public List<TotalStock> TotalStock = new List<TotalStock> { };
        public List<StockNew> NewVehicle = new List<StockNew> { };
        public List<StockUsed> UsedVehicle = new List<StockUsed> { };

        public List<ForSaleTotalStock> ForSaleTotalStock = new List<ForSaleTotalStock> { };
        public List<ForSaleStockNew> ForSaleNewVehicle = new List<ForSaleStockNew> { };
        public List<ForSaleStockUsed> ForSaleUsedVehicle = new List<ForSaleStockUsed> { };

        static int indexForCars;
        public bool listAddNewVehicle;
        public bool listAddAnotherVehicleLoop;

        public string newVehicleUsedOrNew;
        public string newVehicleCarorMotorcycle;


        public Lists()
        {
            NewVehicle.Add(new Car(369000, 2016, "Subaru", "Legacy", 8, 4));
            UsedVehicle.Add(new UsedCar(96000, 2006, "Seat", "Leon", 4, 4));
            NewVehicle.Add(new Motorcycle(118000, 2016, "Honda", "Hayabusa", 2, 4));


            ForSaleNewVehicle.Add(new ForSaleCar(329000, 2016, "Subaru", "Legacy", 8, 1000));
            ForSaleUsedVehicle.Add(new ForSaleUsedCar(85000, 1996, "Seat", "Leon", 4, 1000));
            ForSaleNewVehicle.Add(new ForSaleMotorcycle(100000, 2016, "Honda", "Hayabusa", 2, 1000));

            ListUpdater();
        }

        public void ListAddNewVehicle(Lists lists, Economy economy)
        {
            listAddNewVehicle = true;
            while (listAddNewVehicle)
            {
                Console.WriteLine("Är det ett Begagnat eller Nytt fordon?");
                Console.WriteLine("Använd B, N eller A för att Avbryta");
                var addNewVehicleUserInputUsedOrNew = Console.ReadKey(true).Key;

                switch (addNewVehicleUserInputUsedOrNew)
                {
                    case ConsoleKey.B:
                        newVehicleUsedOrNew = "Begagnad";
                        ListAddAnotherVehicle(lists, economy);
                        break;

                    case ConsoleKey.N:
                        newVehicleUsedOrNew = "Ny";
                        ListAddAnotherVehicle(lists, economy);
                        break;

                    case ConsoleKey.A:
                        listAddAnotherVehicleLoop = false;
                        listAddNewVehicle = false;
                        return;

                    default:
                        Console.WriteLine("Du måste använda B, N eller A.");
                        break;
                }
                ListUpdater();
            }



        }
        public void ListAddAnotherVehicle(Lists lists, Economy economy)
        {
            listAddAnotherVehicleLoop = true;
            while (listAddAnotherVehicleLoop)
            {
                Console.WriteLine("Är det en bil eller en motorcykel?");
                Console.WriteLine("Använd B, M eller A för att Avbryta");
                var addNewVehicleUserInputCarOrMotorcycle = Console.ReadKey(true).Key;

                switch (addNewVehicleUserInputCarOrMotorcycle)
                {
                    case ConsoleKey.B:
                        newVehicleCarorMotorcycle = "Bile";
                        AddingAnotherVehicleFinalStep(lists, economy);
                        break;

                    case ConsoleKey.M:
                        newVehicleCarorMotorcycle = "Motorcykel";
                        AddingAnotherVehicleFinalStep(lists, economy);
                        break;

                    case ConsoleKey.A:
                        listAddAnotherVehicleLoop = false;
                        listAddNewVehicle = false; break;
                    default:
                        Console.WriteLine("Du måste använda B, N eller A.");
                        break;
                }
            }
        }



        private void AddingAnotherVehicleFinalStep(Lists lists, Economy economy)
        {
            Console.Clear();

            if (newVehicleUsedOrNew == "Begagnad")
                Console.WriteLine("Begagnat fordon");
            else
                Console.WriteLine("Nytt fordon");

            Console.WriteLine("---");

            Console.Write("{0}ns tillverkare: ", newVehicleCarorMotorcycle);
            string newVehicleManufacturer = Console.ReadLine();

            Console.Write("{0}ns modell: ", newVehicleCarorMotorcycle);
            string newVehicleModel = Console.ReadLine();

            Console.Write("{0}ns pris: ", newVehicleCarorMotorcycle);
            int newVehiclePrice = int.Parse(Console.ReadLine());

            Console.Write("{0}ns tillverkningsår: ", newVehicleCarorMotorcycle);
            int newVehicleManufacturedYear = int.Parse(Console.ReadLine());

            Console.Write("Antal fordon att lägga till av modellen: ");
            int newVehicleAmount = int.Parse(Console.ReadLine());

            if (newVehicleUsedOrNew == "Begagnad")
            {
                Console.Write("Antal tidigare ägare: ");
                int newVehiclePreviousOwners = int.Parse(Console.ReadLine());

                if (newVehicleCarorMotorcycle == "Bile")
                {
                    Console.WriteLine("Lagrar följande: {0} {1}. {2} kronor. {3} tidigare ägare från {4}. {5} stycken till lagret.", newVehicleManufacturer, newVehicleModel, newVehiclePrice, newVehiclePreviousOwners, newVehicleManufacturedYear, newVehicleAmount);

                    UsedVehicle.Add(new UsedCar((newVehiclePrice + economy.RandomizedCreatedCarPrice()),
                                                newVehicleManufacturedYear,
                                                newVehicleManufacturer,
                                                newVehicleModel,
                                                newVehiclePreviousOwners,
                                                newVehicleAmount));

                    ForSaleUsedVehicle.Add(new ForSaleUsedCar((newVehiclePrice + economy.RandomizedCreatedCarPrice()),
                            newVehicleManufacturedYear,
                            newVehicleManufacturer,
                            newVehicleModel,
                            newVehiclePreviousOwners,
                            1000));
                }
                else if (newVehicleCarorMotorcycle == "Motorcykel")
                {
                    Console.WriteLine("Lagrar följande: {0} {1}. {2} kronor. {3} tidigare ägare från {4}. {5} stycken till lagret.", newVehicleManufacturer, newVehicleModel, newVehiclePrice, newVehiclePreviousOwners, newVehicleManufacturedYear, newVehicleAmount);

                    UsedVehicle.Add(new UsedMotorCycle((newVehiclePrice + economy.RandomizedCreatedCarPrice()),
                                                        newVehicleManufacturedYear,
                                                        newVehicleManufacturer,
                                                        newVehicleModel,
                                                        newVehiclePreviousOwners,
                                                        newVehicleAmount));
                    ForSaleUsedVehicle.Add(new ForSaleUsedMotorCycle((newVehiclePrice + economy.RandomizedCreatedCarPrice()),
                                    newVehicleManufacturedYear,
                                    newVehicleManufacturer,
                                    newVehicleModel,
                                    newVehiclePreviousOwners,
                                    1000));
                }
            }
            else if (newVehicleUsedOrNew == "Ny")
            {
                Console.Write("Garantiperiod: ");
                int newVehicleWarrantyPeriod = int.Parse(Console.ReadLine());

                if (newVehicleCarorMotorcycle == "Bile")
                {
                    Console.WriteLine("Lagrar följande: {0} {1}. {2} kronor. {3} års garanti. Tillverkad {4}. {5} stycken till lagret.", newVehicleManufacturer, newVehicleModel, newVehiclePrice, newVehicleWarrantyPeriod, newVehicleManufacturedYear, newVehicleAmount);

                    NewVehicle.Add(new Car((newVehiclePrice + economy.RandomizedCreatedCarPrice()),
                                            newVehicleManufacturedYear,
                                            newVehicleManufacturer,
                                            newVehicleModel,
                                            newVehicleWarrantyPeriod,
                                            newVehicleAmount));
                    ForSaleNewVehicle.Add(new ForSaleCar((newVehiclePrice + economy.RandomizedCreatedCarPrice()),
                        newVehicleManufacturedYear,
                        newVehicleManufacturer,
                        newVehicleModel,
                        newVehicleWarrantyPeriod,
                        1000));

                }
                else if (newVehicleCarorMotorcycle == "Motorcykel")
                {
                    Console.WriteLine("Lagrar följande: {0} {1}. {2} kronor. {3} års garanti. Tillverkad {4}. {5} stycken till lagret.", newVehicleManufacturer, newVehicleModel, newVehiclePrice, newVehicleWarrantyPeriod, newVehicleManufacturedYear, newVehicleAmount);

                    NewVehicle.Add(new Motorcycle((newVehiclePrice + economy.RandomizedCreatedCarPrice()),
                                                    newVehicleManufacturedYear,
                                                    newVehicleManufacturer,
                                                    newVehicleModel,
                                                    newVehicleWarrantyPeriod,
                                                    newVehicleAmount));
                    ForSaleNewVehicle.Add(new ForSaleMotorcycle((newVehiclePrice + economy.RandomizedCreatedCarPrice()),
                                newVehicleManufacturedYear,
                                newVehicleManufacturer,
                                newVehicleModel,
                                newVehicleWarrantyPeriod,
                                1000));
                }
            }
            listAddAnotherVehicleLoop = false;
            listAddNewVehicle = false;

            ListUpdater();
            Console.WriteLine("(Tryck Enter för att återgå till menysystemet)");
            Console.ReadLine();
        }

        public void ListAddToExistingVehicle()
        {
            Console.WriteLine("Vilket fordon vill du lägga till fler av?");
            int userInputInAddToExistingVehicle = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur många vill du lägga till i lagret?");
            int stockToAddToExistingVehicle = int.Parse(Console.ReadLine());

            if (TotalStock[userInputInAddToExistingVehicle - 1]
                                .GetType()
                                .BaseType
                                .ToString() == "Labb4___BBOB.StockUsed")
            {
                UsedVehicle[userInputInAddToExistingVehicle - NewVehicle.Count() - 1].Amount += stockToAddToExistingVehicle;
            }
            else
            {
                NewVehicle[userInputInAddToExistingVehicle - 1].Amount += stockToAddToExistingVehicle;
            }

            ListUpdater();
        }

        public void ListRemoveExistingVehicle()
        {
            Console.WriteLine("Vilket fordon vill du ta bort av?");
            int userInputInRemoveFromExistingVehicle = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur många vill du ta bort ur lagret?");
            int stockToRemoveFromExistingVehicle = int.Parse(Console.ReadLine());

            if (TotalStock[userInputInRemoveFromExistingVehicle - 1]
                                .GetType()
                                .BaseType
                                .ToString() == "Labb4___BBOB.StockUsed")
            {
                if (stockToRemoveFromExistingVehicle >= (UsedVehicle[userInputInRemoveFromExistingVehicle - NewVehicle.Count() - 1].Amount))
                {
                    Console.WriteLine("Vill du ta bort {0} {1}? (J/N)", (UsedVehicle[userInputInRemoveFromExistingVehicle - NewVehicle.Count() - 1].Manufacturer), (UsedVehicle[userInputInRemoveFromExistingVehicle - NewVehicle.Count() - 1].Model));
                    var input = Console.ReadKey(true).Key;

                    switch (input)
                    {
                        case ConsoleKey.J:
                            UsedVehicle.RemoveAt(userInputInRemoveFromExistingVehicle - NewVehicle.Count() - 1);
                            break;

                        case ConsoleKey.N:
                            Console.WriteLine("Okej. Nollställer lagret för {0} {1}.", (UsedVehicle[userInputInRemoveFromExistingVehicle - NewVehicle.Count() - 1].Manufacturer), (UsedVehicle[userInputInRemoveFromExistingVehicle - NewVehicle.Count() - 1].Model));
                            UsedVehicle[userInputInRemoveFromExistingVehicle - NewVehicle.Count() - 1].Amount = 0;
                            break;
                        default: Console.WriteLine("Använd enbart J eller N."); break;
                    }
                }
                else
                {
                    UsedVehicle[userInputInRemoveFromExistingVehicle - NewVehicle.Count() - 1].Amount -= stockToRemoveFromExistingVehicle;
                }
            }
            else
            {
                if (stockToRemoveFromExistingVehicle >= (NewVehicle[userInputInRemoveFromExistingVehicle - 1].Amount))
                {
                    Console.WriteLine("Vill du ta bort {0} {1}? (J/N)", (NewVehicle[userInputInRemoveFromExistingVehicle - 1].Manufacturer), (NewVehicle[userInputInRemoveFromExistingVehicle - 1].Model));
                    var input = Console.ReadKey(true).Key;

                    switch (input)
                    {
                        case ConsoleKey.J:
                            NewVehicle.RemoveAt(userInputInRemoveFromExistingVehicle - 1);
                            break;

                        case ConsoleKey.N:
                            Console.WriteLine("Okej. Nollställer lagret för {0} {1}.", (NewVehicle[userInputInRemoveFromExistingVehicle - 1].Manufacturer), (UsedVehicle[userInputInRemoveFromExistingVehicle - 1].Model));
                            
                            NewVehicle[userInputInRemoveFromExistingVehicle - 1].Amount = 0;
                            break;
                        default: Console.WriteLine("Använd enbart J eller N."); break;
                    }
                }
                else
                {
                    NewVehicle[userInputInRemoveFromExistingVehicle - 1].Amount -= stockToRemoveFromExistingVehicle;
                }
            }
            ListUpdater();
            Console.WriteLine("Tryck Enter för att fortsätta.");
            Console.ReadLine();
        }

        public void ListUpdater()
        {
            TotalStock.Clear();
            TotalStock.AddRange(NewVehicle);
            TotalStock.AddRange(UsedVehicle);

            ForSaleTotalStock.Clear();
            ForSaleTotalStock.AddRange(ForSaleNewVehicle);
            ForSaleTotalStock.AddRange(ForSaleUsedVehicle);

        }

        internal void ShowNewStockMenu()
        {
            Console.Clear();
            Console.WriteLine("Nya fordon i lager:");
            foreach (var vehicle in NewVehicle)
            {
                Console.WriteLine(vehicle.Presentation());
            }
            Console.WriteLine("---");
            Console.WriteLine("(Tryck enter för att återgå)");
            Console.ReadLine();
        }

        internal void ShowUsedStockMenu()
        {
            Console.Clear();
            Console.WriteLine("Begagnade fordon i lager:");
            foreach (var vehicle in UsedVehicle)
            {
                Console.WriteLine(vehicle.Presentation());
            }
            Console.WriteLine("---");
            Console.WriteLine("(Tryck enter för att återgå)");
            Console.ReadLine();
        }

        internal void ShowTotalStockMenu()
        {
            Console.Clear();
            Console.WriteLine("Alla fordon i lager:");
            foreach (var vehicle in TotalStock)
            {
                Console.WriteLine(vehicle.Presentation());
            }
            Console.WriteLine("---");
            Console.WriteLine("(Tryck enter för att återgå)");
            Console.ReadLine();
        }

        internal void SimplePresentation()
        {
            indexForCars = 1;
            foreach (var vehicle in TotalStock)
            {
                Console.WriteLine("{0}. {1}", indexForCars, vehicle.Presentation());
                indexForCars++;
            }
        }

        internal void SimpleForSalePresentation()
        {
            indexForCars = 1;
            foreach (var vehicle in ForSaleTotalStock)
            {
                Console.WriteLine("{0}. {1}", indexForCars, vehicle.Presentation());
                indexForCars++;
            }
        }
    }
}
