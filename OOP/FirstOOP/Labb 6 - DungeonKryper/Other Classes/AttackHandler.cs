using Labb_6___DungeonKryper.Classes.Objects;
using Labb_6___DungeonKryper.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___DungeonKryper.Other_Classes
{
    class AttackHandler
    {
        public static void Kill(Location currentLocation, Runtime runtime, UI userInterface, List<IEnvironment> environments, int CurrentRoomNumber)
        {
            int i = 1;
            int amountOfMobs = 0;
            Console.WriteLine("Which mob do you want to kill?");
            foreach (var mob in environments[CurrentRoomNumber - 1000].RoomContent)
            {
                amountOfMobs = environments[CurrentRoomNumber - 1000].RoomContent.Count;
                Console.WriteLine(String.Format("{0}. {1}", i, mob.Description));
                i++;
            }
            if (amountOfMobs == 0)
            {
                Console.WriteLine("There are no mobs in the vicinity.");
                Console.ReadLine();
            }
            else
            {
                int playerInput = 0;
                bool attackController = true;
                while (attackController)
                {
                    Console.Write("Kill mob number: ");
                    try
                    {
                        playerInput = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {

                    }

                    if (playerInput > amountOfMobs || playerInput <= 0)
                    {
                        Console.WriteLine("You can't attack that. Try again");
                    }
                    else
                    {
                        attackController = false;
                    }
                }
                playerInput--;
                Console.WriteLine("Okay. Attacking {0}.", environments[CurrentRoomNumber - 1000].RoomContent[playerInput].Description);
                Console.ReadLine();
                MobAttacker(environments, CurrentRoomNumber, playerInput);
            }
        }

        private static void MobAttacker(List<IEnvironment> environments, int currentRoomNumber, int playerInput)
        {
            Random PlayerAttackLevel = new Random();
            int playerMinAttack = 0;
            int playerMaxAttack = 0;

            playerMinAttack = Player.Level + Player.Strength - 1;
            playerMaxAttack = Player.Level * (Player.Strength + Player.Level + 1);

            int playerAttack = PlayerAttackLevel.Next(playerMinAttack, playerMaxAttack);
            int mobReset = environments[currentRoomNumber - 1000].RoomContent[playerInput].Health;

            bool attackLoop = true;
            while (attackLoop)
            {
                playerAttack = PlayerAttackLevel.Next(playerMinAttack, playerMaxAttack);
                environments[currentRoomNumber - 1000].RoomContent[playerInput].Health = environments[currentRoomNumber - 1000].RoomContent[playerInput].Health - playerAttack;
                Console.WriteLine("You do {0} damage to {1}. It has {2} health left.", playerAttack, environments[currentRoomNumber - 1000].RoomContent[playerInput].Description, environments[currentRoomNumber - 1000].RoomContent[playerInput].Health);


                if (environments[currentRoomNumber - 1000].RoomContent[playerInput].Health < 0)
                {
                    Console.WriteLine("{0} died.", environments[currentRoomNumber - 1000].RoomContent[playerInput].Description);

                    Random experienceGain = new Random();

                    if (environments[currentRoomNumber - 1000].RoomContent[playerInput].Level == Player.Level)
                    {
                        Player.LevelSystem(experienceGain.Next(90, 110));
                    }

                    else if (environments[currentRoomNumber - 1000].RoomContent[playerInput].Level + 1 == Player.Level)
                    {
                        Player.LevelSystem(experienceGain.Next(20, 40));
                    }

                    else if (environments[currentRoomNumber - 1000].RoomContent[playerInput].Level + 2 == Player.Level)
                    {
                        Player.LevelSystem(experienceGain.Next(1, 8));
                    }
                    else if (environments[currentRoomNumber - 1000].RoomContent[playerInput].Level - 1 == Player.Level)
                    {
                        Player.LevelSystem(experienceGain.Next(200, 240));
                    }
                    else if (environments[currentRoomNumber - 1000].RoomContent[playerInput].Level - 2 == Player.Level)
                    {
                        Player.LevelSystem(experienceGain.Next(300, 380));
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("You gain absolutely nothing from this fight.");
                        Console.WriteLine("Try attacking tougher enemies.");
                        Console.ResetColor();
                    }

                    Player.Gains(environments, currentRoomNumber, playerInput);
                    attackLoop = false;
                }

                else
                {
                    MobCounterAttack(environments, currentRoomNumber, playerInput, attackLoop, mobReset);

                    if (Player.Health > 0)
                    {
                        Console.WriteLine("Do you wish to flee (y)?");
                        string input = Console.ReadLine();

                        if (input == "y")
                        {
                            Console.WriteLine("You put your tail between your legs and runs away from your enemy.");
                            Console.ReadLine();
                            environments[currentRoomNumber - 1000].RoomContent[playerInput].Health = mobReset;
                            attackLoop = false;
                        }
                    }

                    else
                    {
                        Console.WriteLine("You have been severely wounded and have to rest for a while.");
                        Console.WriteLine("When you wake up, you quickly gather your things and treat your wounds.");
                        Player.Health = Player.FullHealth;
                        Console.ReadLine();
                    }
                }
            }
            environments[currentRoomNumber - 1000].RoomContent[playerInput].Health = mobReset;
        }

        internal static void Consider(Location currentLocation, Runtime runtime, UI userInterface, List<IEnvironment> environments, int currentRoomNumber)
        {
            int i = 1;
            int amountOfMobs = 0;
            Console.WriteLine("Which mob do you want to consider?");
            foreach (var mob in environments[currentRoomNumber - 1000].RoomContent)
            {
                amountOfMobs = environments[currentRoomNumber - 1000].RoomContent.Count;
                Console.WriteLine(String.Format("{0}. {1}", i, mob.Description));
                i++;
            }
            if (amountOfMobs == 0)
            {
                Console.WriteLine("There are no mobs in the vicinity.");
                Console.ReadLine();
            }
            else
            {
                int playerInput = 0;
                bool attackController = true;
                while (attackController)
                {
                    Console.Write("Consider mob number: ");
                    try
                    {
                        playerInput = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {

                    }

                    if (playerInput > amountOfMobs || playerInput <= 0)
                    {
                        Console.WriteLine("You can't consider that. Try again");
                    }
                    else
                    {
                        attackController = false;
                    }
                }
                playerInput--;

                if (environments[currentRoomNumber - 1000].RoomContent[playerInput].Level == Player.Level)
                {
                    Console.WriteLine("This should be a fair fight. You are both the same level.");
                }

                else if (environments[currentRoomNumber - 1000].RoomContent[playerInput].Level + 1 == Player.Level)
                {
                    Console.WriteLine("This should be an easy fight. Enemy is weaker than you.");
                }

                else if (environments[currentRoomNumber - 1000].RoomContent[playerInput].Level + 2 == Player.Level)
                {
                    Console.WriteLine("This should be a very easy fight. Enemy is much weaker than you.");
                }
                else if (environments[currentRoomNumber - 1000].RoomContent[playerInput].Level - 1 == Player.Level)
                {
                    Console.WriteLine("This should be a tough fight. Enemy is stronger than you.");
                }
                else if (environments[currentRoomNumber - 1000].RoomContent[playerInput].Level - 2 == Player.Level)
                {
                    Console.WriteLine("This should be a very tough fight. Enemy is much stronger than you.");
                }

                else
                {
                    int levelDifference = 0;
                    levelDifference = environments[currentRoomNumber - 1000].RoomContent[playerInput].Level - Player.Level;

                    if (levelDifference < 0)
                    {
                        Console.WriteLine("You will not gain anything from this fight. The enemy is too weak");
                    }
                    else
                    {
                        Console.WriteLine("You will most certainly die. The enemy is way too strong.");
                    }
                }
                Console.ReadLine();
            }
        }

        private static bool MobCounterAttack(List<IEnvironment> environments, int currentRoomNumber, int playerInput, bool attackLoop, int mobReset)
        {
            Random MobAttackLevel = new Random();
            int mobMinAttack = 0;
            int mobMaxAttack = 0;

            mobMinAttack = environments[currentRoomNumber - 1000].RoomContent[playerInput].Level + environments[currentRoomNumber - 1000].RoomContent[playerInput].Strength - 1;
            mobMaxAttack = environments[currentRoomNumber - 1000].RoomContent[playerInput].Level * (environments[currentRoomNumber - 1000].RoomContent[playerInput].Strength + environments[currentRoomNumber - 1000].RoomContent[playerInput].Level + 1);

            int mobAttack = MobAttackLevel.Next(mobMinAttack, mobMaxAttack);

            Player.Health = Player.Health - mobAttack;

            Console.WriteLine("He does {0} damage. You have {1} health left.", mobAttack, Player.Health);

            if (Player.Health <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You died");
                Console.ResetColor();
                Console.ReadLine();
                environments[currentRoomNumber - 1000].RoomContent[playerInput].Health = mobReset;
                return attackLoop = false;
            }

            mobAttack = MobAttackLevel.Next(mobMinAttack, mobMaxAttack);
            Console.ReadLine();
            return attackLoop = true;
        }
    }
}
