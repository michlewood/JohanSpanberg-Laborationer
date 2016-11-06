using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb_6___DungeonKryper.Interfaces;
using Labb_6___DungeonKryper.Other_Classes;
using Labb_6___DungeonKryper.Classes.Lists;

namespace Labb_6___DungeonKryper.Classes.Objects
{
    class Player
    {
        public static int Health { get; set; }
        public static int FullHealth { get; set; }
        public static int Moves { get; set; }
        public static int FullMoves { get; set; }
        public static int Level { get; set; }
        public static int Experience { get; set; }
        public static int MaxExperience { get; set; }
        public static int Strength { get; set; }
        public static bool noExperience { get; set; }
        public static int attackRatio { get; set; }
        public static int goldCoins { get; set; }

        public static void LevelSystem(int inExperience)
        {
            if (noExperience == false)
            {
                if ((inExperience + Experience) >= MaxExperience)
                {
                    int tempExperience = (inExperience + Experience);
                    Experience = (tempExperience - MaxExperience);
                    if (Level == 201)
                    {
                        Console.WriteLine("You have reached remort once again.");
                        Console.WriteLine("You have a total of {0} experience left to reach remort again.", MaxExperience - Experience);
                    }

                    else
                    {
                        Level++;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Congratulations. You have reached level {0}.", Level);
                        Console.WriteLine("You have a total of {0} experience left to reach level {1}.", MaxExperience - Experience, Level + 1);
                        LevelUpSystem();
                        Console.ResetColor();
                    }

                    return;
                }
                else
                {
                    Experience = Experience + inExperience;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You gained {0} experience.", inExperience);
                    Console.WriteLine("You have a total of {0} experience left to reach level {1}.", MaxExperience - Experience, Level + 1);
                    Console.ResetColor();
                    return;
                }
            }
            else
            {
                Console.WriteLine("You have chosen not to recieve experience at this time. To toggle this type noexp");
                Console.ReadLine();
            }
        }
        static void LevelUpSystem()
        {
            Random random = new Random();

            var additionalMoves = random.Next(1, 10);
            FullMoves = FullMoves + additionalMoves;

            var additionalStrength = random.Next(1, 10);
            Strength = Strength + additionalStrength;

            var additionalHealth = random.Next(1, 10);
            FullHealth = FullHealth + additionalHealth;

            Console.WriteLine("━━━");
            Console.WriteLine("You gained:");
            Console.WriteLine("+{0} moves", additionalMoves);
            Console.WriteLine("+{0} strength", additionalStrength);
            Console.WriteLine("+{0} health", additionalHealth);
            Console.WriteLine("━━━");
        }

        internal static void Gains(List<IEnvironment> environments, int currentRoomNumber, int playerInput)
        {
            Random goldGain = new Random();
            int goldGained = goldGain.Next(environments[currentRoomNumber - 1000].RoomContent[playerInput].Level, environments[currentRoomNumber - 1000].RoomContent[playerInput].Level + 11);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You got {0} gold from the corpse of the {1}.", goldGained, environments[currentRoomNumber - 1000].RoomContent[playerInput].Description);
            Console.ResetColor();
            goldCoins = goldCoins + goldGained;
            Console.ReadLine();
        }

        internal static void EquipmentGainSystem(int gearDropChance)
        {
            Random equipmentDropChance = new Random();
            Random equipmentDropType = new Random();

            int dropType = equipmentDropType.Next(0, 8);
            int dropChance = equipmentDropChance.Next(1, 1001);
            if (dropChance >= (1001 - gearDropChance))
            {

            }
        }

        public static void WhoisScreen()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("┃         Player Stats           ");
            Console.WriteLine("┃");
            Console.WriteLine("┃   Level: {0}                     ", Level);
            Console.WriteLine("┃   Moves: {0}                    ", FullMoves);
            Console.WriteLine("┃   Strength: {0}                  ", Strength);
            Console.WriteLine("┃   Experience: {0}                  ", Experience);
            Console.WriteLine("┃   Gold coins: {0}                  ", goldCoins);
            Console.WriteLine("┃ ");
            Console.WriteLine("Press <enter> to return to the game.");
            Console.ReadLine();
        }

        public static void Help()
        {
            Console.Clear();
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine("┃                      Available commands:                     ┃");
            Console.WriteLine("┣━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┫");
            Console.WriteLine("┃  n - Go north                                                ┃");
            Console.WriteLine("┃  s - Go south                                                ┃");
            Console.WriteLine("┃  w - Go west                                                 ┃");
            Console.WriteLine("┃  e - Go east                                                 ┃");
            Console.WriteLine("┣━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┫");
            Console.WriteLine("┃  sleep / sl - Go to sleep, replenishes stats                 ┃");
            Console.WriteLine("┃  quest accept / q a / qa - Accept/Move forward with quest    ┃");
            Console.WriteLine("┃  examine / ex - Examine the room you are in                  ┃");
            Console.WriteLine("┃  examine mob / ex mob - Examine the mobs in the room         ┃");
            Console.WriteLine("┃  listen / list - Listen to the mobs in the room              ┃");
            Console.WriteLine("┃  noexp - Toggle experience gains                             ┃");
            Console.WriteLine("┃  whois - Check your current stats                            ┃");
            Console.WriteLine("┃  kill / k - Attacks a mob                                    ┃");
            Console.WriteLine("┃  consider / con - Considers a mob before a fight             ┃");
            Console.WriteLine("┃  help - shows this screen                                    ┃");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
            Console.WriteLine("Press <enter> to return to the game.");
            Console.ReadLine();
        }
    }
}
