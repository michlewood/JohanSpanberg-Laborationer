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
            //Console.WriteLine("There are {0} mobs in this room.", amountOfMobs);
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

            while (environments[currentRoomNumber - 1000].RoomContent[playerInput].Health > 0 && Player.Health > 0)
            {
                playerAttack = PlayerAttackLevel.Next(playerMinAttack, playerMaxAttack);
                environments[currentRoomNumber - 1000].RoomContent[playerInput].Health = environments[currentRoomNumber - 1000].RoomContent[playerInput].Health - playerAttack;
                Console.WriteLine("You do {0} damage to {1}. It has {2} health left.", playerAttack, environments[currentRoomNumber - 1000].RoomContent[playerInput].Description, environments[currentRoomNumber - 1000].RoomContent[playerInput].Health);

                if (environments[currentRoomNumber - 1000].RoomContent[playerInput].Health < 0)
                {
                    Console.WriteLine("{0} died.", environments[currentRoomNumber - 1000].RoomContent[playerInput].Description);
                    Console.ReadLine();
                }

                else
                {
                    MobCounterAttack(environments, currentRoomNumber, playerInput);
                }
            }
        }

        private static void MobCounterAttack(List<IEnvironment> environments, int currentRoomNumber, int playerInput)
        {
            Random MobAttackLevel = new Random();
            int mobMinAttack = 0;
            int mobMaxAttack = 0;

            mobMinAttack = environments[currentRoomNumber - 1000].RoomContent[playerInput].Level + environments[currentRoomNumber - 1000].RoomContent[playerInput].Strength - 1;
            mobMaxAttack = environments[currentRoomNumber - 1000].RoomContent[playerInput].Level * (environments[currentRoomNumber - 1000].RoomContent[playerInput].Strength + environments[currentRoomNumber - 1000].RoomContent[playerInput].Level + 1);

            int mobAttack = MobAttackLevel.Next(mobMinAttack, mobMaxAttack);

            Player.Health = Player.Health - mobAttack;


            Console.WriteLine("He does {0} damage. You have {1} health left.", mobAttack, Player.Health);

            if (Player.Health < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You died");
                Console.ResetColor();
                Console.ReadLine();
            }

            mobAttack = MobAttackLevel.Next(mobMinAttack, mobMaxAttack);
            Console.ReadLine();

        }
    }
}
