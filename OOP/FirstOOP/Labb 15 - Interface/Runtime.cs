using Labb_15___Interface.Models;
using System;

namespace Labb_15___Interface
{
    internal class Runtime
    {
        SpaceShip spaceShipOne = new SpaceShip();
        Bicycle bicycleOne = new Bicycle();
        Car carOne = new Car();
        Boulder boulderOne = new Boulder();
        Button buttonOne = new Button();

        internal void Start()
        {
            bool mainMenuLoop = true;
            while (mainMenuLoop)
            {
                Console.Clear();
                Console.WriteLine("Select vehicle.");
                Console.WriteLine("1. Spaceship");
                Console.WriteLine("2. Bicycle");
                Console.WriteLine("3. Car");
                Console.WriteLine("Pushable items:");
                Console.WriteLine("4. Boulder");
                Console.WriteLine("5. Button");
                var input = Console.ReadKey(true).Key;

                int vehicleChoice = 0;
                int pushableChoice = 0;

                switch (input)
                {
                    case ConsoleKey.D1:
                        vehicleChoice = 0;
                        VehicleCheckStatus(vehicleChoice);
                        break;
                    case ConsoleKey.D2:
                        vehicleChoice = 1;
                        VehicleCheckStatus(vehicleChoice);
                        break;
                    case ConsoleKey.D3:
                        vehicleChoice = 2;
                        VehicleCheckStatus(vehicleChoice);
                        break;
                    case ConsoleKey.D4:
                        pushableChoice = 0;
                        PushObject(pushableChoice);
                        break;
                    case ConsoleKey.D5:
                        pushableChoice = 1;
                        PushObject(pushableChoice);
                        break;
                    default:
                        Console.WriteLine("Wrong input.");
                        break;
                }
            }
        }

        private void PushObject(int pushableChoice)
        {
            if (pushableChoice == 0)
            {
                Console.WriteLine(boulderOne.Push());  
            }
            else
                Console.WriteLine(buttonOne.Push());

            Console.ReadLine();
        }

        private void VehicleCheckStatus(int vehicleChoice)
        {
            bool vehicleCheckStatusLoop = true;
            while (vehicleCheckStatusLoop)
            {
                Console.Clear();
                Console.Write("What would you like to check on your ");

                if (vehicleChoice == 0)
                {
                    Console.WriteLine("spaceship?");
                }
                else if (vehicleChoice == 1)
                {
                    Console.WriteLine("bicycle?");
                }
                else
                {
                    Console.WriteLine("car?");
                }
                Console.WriteLine("\n1. Start engine.");
                Console.WriteLine("2. Stop engine.");
                Console.WriteLine("3. Unlock.");
                Console.WriteLine("4. Lock.");
                Console.WriteLine("5. Return to main menu.");


                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        StartEngine(vehicleChoice);
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D2:
                        StopEngine(vehicleChoice);
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D3:
                        UnlockVehicle(vehicleChoice);
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D4:
                        LockVehicle(vehicleChoice);
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D5:
                        vehicleCheckStatusLoop = false;
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }
        }

        private void StartEngine(int vehicleChoice)
        {
            if (vehicleChoice == 0 && spaceShipOne.Started == false)
            {
                spaceShipOne.Start();
            }
            else if (vehicleChoice == 1 && bicycleOne.Started == false)
            {
                bicycleOne.Start();
            }
            else if (vehicleChoice == 2 && carOne.Started == false)
            {
                carOne.Start();
            }
            else
            {
                Console.WriteLine("Already started.");
            }
        }
        private void StopEngine(int vehicleChoice)
        {
            if (vehicleChoice == 0 && spaceShipOne.Started == true)
            {
                spaceShipOne.Stop();
            }
            else if (vehicleChoice == 1 && bicycleOne.Started == true)
            {
                bicycleOne.Stop();
            }
            else if (vehicleChoice == 2 && carOne.Started == true)
            {
                carOne.Stop();
            }

            else
            {
                Console.WriteLine("Already stopped.");
            }
        }
        private void UnlockVehicle(int vehicleChoice)
        {
            if (vehicleChoice == 0 && spaceShipOne.Locked == true)
            {
                spaceShipOne.Unlock();
            }
            else if (vehicleChoice == 1 && bicycleOne.Started == true)
            {
                bicycleOne.Unlock();
            }
            else if (vehicleChoice == 2 && carOne.Started == true)
            {
                carOne.Unlock();
            }

            else
            {
                Console.WriteLine("Already unlocked.");
            }
        }
        private void LockVehicle(int vehicleChoice)
        {
            if (vehicleChoice == 0 && spaceShipOne.Locked == false)
            {
                spaceShipOne.Lock();
            }
            else if (vehicleChoice == 1 && bicycleOne.Started == false)
            {
                bicycleOne.Lock();
            }
            else if (vehicleChoice == 2 && carOne.Started == false)
            {
                carOne.Lock();
            }

            else
            {
                Console.WriteLine("Already locked.");
            }
        }
    }
}