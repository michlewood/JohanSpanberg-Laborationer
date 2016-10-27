using Labb_6___DungeonKryper.Classes.Environment;
using Labb_6___DungeonKryper.Classes.Objects;
using Labb_6___DungeonKryper.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___DungeonKryper
{
    class Runtime
    {
        List<INonPlayerCharacter> nonPlayerCharacters = new List<INonPlayerCharacter> { };
        List<IEnvironment> environment = new List<IEnvironment> { };

        public void Start(Runtime runtime)
        {
            environment.Add(new Yard
            {
                Description = "a dark forest.",
                LongDescription = "There really is nothing to see. You see a path going north.",
                Exits = "North",
                EnvironmentLocationX = 0,
                EnvironmentLocationY = 0,
                RoomNumber = 1000,
                ExitNorth = 1001,
                ExitEast = 0,
                ExitSouth = 0,
                ExitWest = 0,
                Contains = 1000,

            });
            environment[0].RoomContent.Add(new Animal
            {
                Name = "dog",
                Description = "A tiny dog",
                Speak = "Woof",
                Type = "Dog",
                ObjectLocationX = 0,
                ObjectLocationY = 0,
                ObjectNumber = 1000,
                Health = 5,
                Level = 1

            });

            environment.Add(new Yard
            {
                Description = "a dark forest.",
                LongDescription = "You can see a small cabin to the west and nothing but dark forest to the north.",
                Exits = "North, South, West",
                EnvironmentLocationX = 1,
                EnvironmentLocationY = 0,
                RoomNumber = 1001,
                ExitSouth = 1000,
                ExitNorth = 1003,
                ExitWest = 1002,
                ExitEast = 0,
                Contains = 0
            });

            environment.Add(new Room
            {
                Description = "a light cabin.",
                LongDescription = "This small cabin have seen better days. The only exit is the door you came in through.",
                Exits = "East",
                EnvironmentLocationX = 1,
                EnvironmentLocationY = -1,
                RoomNumber = 1002,
                ExitEast = 1001,
                ExitSouth = 0,
                ExitWest = 0,
                ExitNorth = 0,
                Contains = 1001
            });
            environment[2].RoomContent.Add(new Human
            {
                Name = "regular man",
                Description = "A tall man",
                Speak = "Come here for a while, and listen.",
                ObjectLocationX = 0,
                ObjectLocationY = 0,
                ObjectNumber = 1001,
                Health = 8,
                Level = 1
            });

            environment.Add(new Yard
            {
                Description = "a dimly lit yard.",
                LongDescription = "The forest clears and you can see some cut grass. To the north it looks more well maintained and to the south there is nothing but forests.",
                Exits = "North, South",
                EnvironmentLocationX = 2,
                EnvironmentLocationY = 0,
                RoomNumber = 1003,
                ExitSouth = 1001,
                ExitNorth = 1004,
                ExitWest = 1002,
                ExitEast = 0,
                Contains = 0
            });
            environment.Add(new Yard
            {
                Description = "a bright yard.",
                LongDescription = "The grass is well cut and you can see a freshly renovated pathway leading north. To the south it looks darker.",
                Exits = "North, South",
                EnvironmentLocationX = 3,
                EnvironmentLocationY = 0,
                RoomNumber = 1004,
                ExitSouth = 1003,
                ExitNorth = 1005,
                ExitEast = 0,
                ExitWest = 0,
                Contains = 1001
            });
            environment[4].RoomContent.Add(new Human
            {
                Name = "regular man",
                Description = "A tall man",
                Speak = "Come here for a while, and listen.",
                ObjectLocationX = 0,
                ObjectLocationY = 0,
                ObjectNumber = 1001,
                Health = 3,
                Level = 1
            });
            environment.Add(new Yard
            {
                Description = "a palace entrance.",
                LongDescription = "A big marble building stands before you to the north. To the south you can see the yard.",
                Exits = "North, South",
                EnvironmentLocationX = 4,
                EnvironmentLocationY = 0,
                RoomNumber = 1005,
                ExitSouth = 1004,
                ExitNorth = 1006,
                ExitEast = 0,
                ExitWest = 0,
                Contains = 1002
            });
            environment[5].RoomContent.Add(new Animal
            {
                Name = "rat",
                Description = "A small rat",
                Speak = "The rat covers in fear.",
                ObjectLocationX = 0,
                ObjectLocationY = 0,
                ObjectNumber = 1002,
                Health = 2,
                Level = 1
            });
            environment[5].RoomContent.Add(new Animal
            {
                Name = "rat",
                Description = "A small rat",
                Speak = "The rat covers in fear.",
                ObjectLocationX = 0,
                ObjectLocationY = 0,
                ObjectNumber = 1002,
                Health = 3,
                Level = 1
            });
            environment.Add(new Room
            {
                Description = "a palace hallway.",
                LongDescription = "The walls are plastered with beautiful paintings, the floor is reflective and the roof looks entirely new. The building draws you in further north, but you can exit in all directions.",
                Exits = "North, South, East, West",
                EnvironmentLocationX = 5,
                EnvironmentLocationY = 0,
                RoomNumber = 1006,
                ExitSouth = 1005,
                ExitNorth = 1007,
                ExitEast = 1008,
                ExitWest = 1009,
                Contains = 0
            });
            environment.Add(new Room
            {
                Description = "a throne room.",
                LongDescription = "The most gold filled room you have ever seen. In the middle there is a man looking fierce. You may exit to the south.",
                Exits = "South",
                EnvironmentLocationX = 6,
                EnvironmentLocationY = 0,
                RoomNumber = 1007,
                ExitSouth = 1006,
                ExitNorth = 0,
                ExitEast = 0,
                ExitWest = 0,
                Contains = 1003
            });
            environment[7].RoomContent.Add(new Human
            {
                Name = "questor",
                Description = "A influental man",
                Speak = "I have a possible quest for you. Type Quest accept to start your quest",
                ObjectLocationX = 0,
                ObjectLocationY = 0,
                ObjectNumber = 1003,
                Health = 99999,
                Level = 201
            });

            environment.Add(new Room
            {
                Description = "a palace room.",
                LongDescription = "Another big room.",
                Exits = "West",
                EnvironmentLocationX = 5,
                EnvironmentLocationY = 1,
                RoomNumber = 1008,
                ExitSouth = 0,
                ExitNorth = 0,
                ExitEast = 0,
                ExitWest = 1006,
                Contains = 0
            });
            environment.Add(new Room
            {
                Description = "a palace room.",
                LongDescription = "Another big room.",
                Exits = "East",
                EnvironmentLocationX = 5,
                EnvironmentLocationY = -1,
                RoomNumber = 1009,
                ExitSouth = 0,
                ExitNorth = 0,
                ExitEast = 1006,
                ExitWest = 0,
                Contains = 0
            });

            // -------------------------------------
            // Slut på rum
            // -------------------------------------

            var userInterface = new UI();
            userInterface.ShownUserInterface(runtime, userInterface);
        }

        internal void UpdateList(int currentRoomNumber)
        {
            if (currentRoomNumber == 0)
                return;
            else
                nonPlayerCharacters = environment[currentRoomNumber - 1000].RoomContent;
        }

        public string RoomDescription(int currentRoomX, int currentRoomY, int currentRoomNumber, Runtime runtime, UI userInterface)
        {
            foreach (var location in environment)
            {
                if (currentRoomNumber == location.RoomNumber)
                {
                    userInterface.CurrentRoomNumber = location.RoomNumber;
                    userInterface.AvailableExits = location.Exits;
                    userInterface.PossibleExitNorth = location.ExitNorth;
                    userInterface.PossibleExitSouth = location.ExitSouth;
                    userInterface.PossibleExitWest = location.ExitWest;
                    userInterface.PossibleExitEast = location.ExitEast;
                    userInterface.CurrentRoomContents = location.Contains;
                    userInterface.CurrentRoomX = location.EnvironmentLocationX;
                    userInterface.CurrentRoomY = location.EnvironmentLocationY;

                    Console.WriteLine("You see {0}", location.Description);

                    return String.Format("The room contains: {0}", RoomContents(runtime, currentRoomNumber, userInterface));
                }
            }

            return "You can't see an exit that way. Try again.";
        }

        public string RoomContents(Runtime runtime, int currentRoomNumber, UI userInterface)
        {
            string numberOfAnimals = "nothing";
            foreach (var animal in environment[currentRoomNumber - 1000].RoomContent)
            {
                if (numberOfAnimals == "nothing")
                {
                    numberOfAnimals = animal.Description;
                }
                else
                    numberOfAnimals += ", " + animal.Description;
            }
            return numberOfAnimals;
        }

        public void UserInput(UI userInterface, Runtime runtime)
        {
            string input = Console.ReadLine().ToLower();

            if (userInterface.Moves == 0 && input == "n" || userInterface.Moves == 0 && input == "s" || userInterface.Moves == 0 && input == "w" || userInterface.Moves == 0 && input == "e")
            {
                Console.WriteLine("You are too fatigued too move. Sleep or examine things to gain your moves back.");
                Console.WriteLine("Press <enter> and try again.");
                Console.ReadLine();
            }

            else
            {
                if (input == "n" && userInterface.PossibleExitNorth >= 0)
                {
                    userInterface.CurrentRoomNumber = userInterface.PossibleExitNorth;
                    userInterface.Moves--;
                }
                else if (input == "s" && userInterface.PossibleExitSouth >= 0)
                {
                    userInterface.CurrentRoomNumber = userInterface.PossibleExitSouth;
                    userInterface.Moves--;
                }
                else if (input == "w" && userInterface.PossibleExitWest >= 0)
                {
                    userInterface.CurrentRoomNumber = userInterface.PossibleExitWest;
                    userInterface.Moves--;
                }
                else if (input == "e" && userInterface.PossibleExitEast >= 0)
                {
                    userInterface.CurrentRoomNumber = userInterface.PossibleExitEast;
                    userInterface.Moves--;
                }
                else if (input == "listen")
                {
                    MobListener(runtime, userInterface);
                    if (userInterface.Moves == userInterface.FullMoves)
                    {
                        userInterface.Moves = userInterface.FullMoves;
                    }
                    else
                    {
                        userInterface.Moves++;
                    }

                }
                else if (input == "examine")
                {
                    RoomExaminer(runtime, userInterface);
                    if (userInterface.Moves == userInterface.FullMoves)
                    {
                        userInterface.Moves = userInterface.FullMoves;
                    }
                    else
                    {
                        userInterface.Moves++;
                    }

                }
                else if (input == "sleep")
                {
                    Console.WriteLine("You quickly fall asleep");
                    Console.WriteLine("Type wake to wake up.");

                    bool asleep = true;
                    while (asleep)
                    {
                        string asleepInput = Console.ReadLine();

                        if (asleepInput == "wake")
                        {
                            Console.WriteLine("You wake up fresh and rested!");
                            Console.WriteLine("Press <enter> to continue.");
                            userInterface.Moves = userInterface.FullMoves;
                            Console.ReadLine();
                            asleep = false;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Not a recognizable command. Press <enter> and try again.");
                    Console.ReadLine();
                }
            }
        }

        private void RoomExaminer(Runtime runtime, UI userInterface)
        {
            foreach (var room in environment)
            {
                if (userInterface.CurrentRoomNumber == room.RoomNumber)
                {
                    Console.WriteLine(room.LongDescription);
                }
                else if (userInterface.CurrentRoomNumber == 0)
                {
                    Console.WriteLine("There really is nothing to see here.");
                    break;
                }
            }
            Console.ReadLine();
        }

        private void MobListener(Runtime runtime, UI userInterface)
        {
            if (nonPlayerCharacters.Count == 0)
            {
                Console.WriteLine("You have nothing to listen to.");
            }
            foreach (var animal in nonPlayerCharacters)
            {
                Console.WriteLine("The {0} says: {1}", animal.Name, animal.Speak);
            }
            Console.ReadLine();
        }
    }
}
