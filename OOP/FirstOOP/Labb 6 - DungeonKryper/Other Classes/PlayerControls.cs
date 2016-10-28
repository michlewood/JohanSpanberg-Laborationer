using Labb_6___DungeonKryper.Classes.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___DungeonKryper.Other_Classes
{
    class PlayerControls
    {
        public void UserInput(UI userInterface, Runtime runtime, Location currentLocation)
        {
            string input = Console.ReadLine().ToLower();

            if (Player.Moves == 0 
                && input == "n" 
                || Player.Moves == 0 
                && input == "s" 
                || Player.Moves == 0 
                && input == "w" 
                || Player.Moves == 0 
                && input == "e")
            {
                Console.WriteLine("You are too fatigued too move. Sleep or examine things to gain your moves back.");
                Console.WriteLine("Press <enter> and try again.");
                Console.ReadLine();
            }

            else
            {
                if (input == "n" 
                    && currentLocation.PossibleExitNorth > 0)
                {
                    currentLocation.CurrentRoomNumber = currentLocation.PossibleExitNorth;
                    Player.Moves--;
                    currentLocation.CurrentRoomX++;
                }
                else if (input == "s" 
                    && currentLocation.PossibleExitSouth > 0)
                {
                    currentLocation.CurrentRoomNumber = currentLocation.PossibleExitSouth;
                    Player.Moves--;
                    currentLocation.CurrentRoomX--;
                }
                else if (input == "w" 
                    && currentLocation.PossibleExitWest > 0)
                {
                    currentLocation.CurrentRoomNumber = currentLocation.PossibleExitWest;
                    Player.Moves--;
                    currentLocation.CurrentRoomY--;
                }
                else if (input == "e" 
                    && currentLocation.PossibleExitEast > 0)
                {
                    currentLocation.CurrentRoomNumber = currentLocation.PossibleExitEast;
                    Player.Moves--;
                    currentLocation.CurrentRoomY++;
                }
                else if (input == "listen" 
                    || input == "lis")
                {
                    runtime.MobListener(currentLocation, runtime, userInterface);
                    if (Player.Moves > Player.FullMoves)
                    {
                        Player.Moves++;
                    }
                }
                else if (input == "examine" 
                    || input == "ex")
                {
                    runtime.RoomExaminer(currentLocation, runtime, userInterface);
                    if (Player.Moves < Player.FullMoves)
                    {
                        Player.Moves++;
                    }
                }
                else if (input == "examine mob"
                || input == "ex mob")
                {
                    runtime.PersonExaminer(currentLocation, runtime, userInterface);
                    if (Player.Moves < Player.FullMoves)
                    {
                        Player.Moves++;
                    }
                }
                else if (input == "quest accept" 
                    || input == "qa" 
                    || input == "q a")
                {
                    QuestSystem.Questgetter(currentLocation, 
                                            userInterface, 
                                            runtime);
                }
                else if (input == "cheat")
                {
                    Player.Moves = 1000;
                    Questor.QuestStarted = true;
                    Questor.QuestHalfway = true;
                    Console.WriteLine("Ok.");
                }
                else if (input == "whois")
                {
                    Player.WhoisScreen();
                }
                else if (input == "help")
                {
                    Player.Help();
                }
                else if (input == "noexp")
                {
                    if (Player.noExperience == false)
                    {
                        Player.noExperience = true;
                        Console.WriteLine("Done. You will not receive experience.");
                    }
                    else
                    {
                        Player.noExperience = false;
                        Console.WriteLine("Done. You will now receive experience.");
                    }
                    Console.ReadLine();
                }
                else if (input == "sleep" 
                        || input == "sl")
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
                            Player.Moves = Player.FullMoves;
                            Console.ReadLine();
                            asleep = false;
                        }
                    }
                }

                else if (input == "n" 
                        || input == "s" 
                        || input == "w" 
                        || input == "e")
                {
                    Console.WriteLine("You don't see an exit that way.");
                    Console.WriteLine("Press <enter> and try again");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("Not a recognizable command. Press <enter> and try again.");
                    Console.ReadLine();
                }
            }
        }
    }
}
