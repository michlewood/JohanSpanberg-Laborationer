using Labb_6___DungeonKryper.Classes.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___DungeonKryper.Other_Classes
{
    class QuestSystem
    {
        public static int ExperienceGain { get; set; }

        internal static void Questgetter(Location currentLocation, UI userInterface, Runtime runtime)
        {
            if (currentLocation.CurrentRoomX == 6 && currentLocation.CurrentRoomY == 0 && Questor.QuestStarted == false)
            {
                Console.WriteLine("You have to find out what my brother has to say. You can find him in the small cabin just outside the palace.");
                Console.WriteLine("If you do this I will reward you plenty. Do you wish to accept? (Y/N)");
                string input = Console.ReadLine().ToLower();

                if (input == "y")
                {
                    Questor.QuestStarted = true;
                    Console.WriteLine("Thank you. Now go and find my brother.");
                    Console.WriteLine("Press <enter> to continue");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("I'm sorry to hear that. Take care and come back when you feel ready.");
                    Console.WriteLine("Press <enter> to continue");
                    Console.ReadLine();
                }
            }
            else if (currentLocation.CurrentRoomX == 1 && currentLocation.CurrentRoomY == -1 && Questor.QuestStarted == true)
            {
                Console.WriteLine("Hello my friend! So my brother sent you, did he?");
                Console.WriteLine("Well I'm sorry he dragged you in to this but you can tell him that");
                Console.WriteLine("I am fine and I will not come home.");
                Console.WriteLine("Press <enter> to continue");
                Questor.QuestHalfway = true;
                Console.ReadLine();
            }
            else if (currentLocation.CurrentRoomX == 6 && currentLocation.CurrentRoomY == 0 && Questor.QuestStarted == true && Questor.QuestHalfway == true)
            {
                Console.WriteLine("Oh, he wont come home? Okay. Thanks for letting me know.");
                Random random = new Random();
                ExperienceGain = random.Next(100, 501);
                Console.WriteLine("Thank you for your work. Here. Have {0} experience.", ExperienceGain);
                Player.LevelSystem(ExperienceGain);
                Console.WriteLine("Press <enter> to continue");
                Questor.QuestStarted = false;
                Questor.QuestHalfway = false;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You can't accept a quest here.");
                Console.WriteLine("Press <enter> to continue");
                Console.ReadLine();
            }

        }
    }
}
