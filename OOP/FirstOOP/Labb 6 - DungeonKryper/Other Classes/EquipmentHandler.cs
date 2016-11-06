using Labb_6___DungeonKryper;
using Labb_6___DungeonKryper.Classes.Lists;
using Labb_6___DungeonKryper.Classes.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___DungeonKryper.Other_Classes
{
    class EquipmentHandler
    {
        internal void Inventory(Worn wornEquipment, Runtime runtime)
        {
            Console.Clear();
            Console.WriteLine("Current equipment:");

            //myLists.Environment[currentRoomNumber - 1000].RoomContent
            int i = 0;
            foreach (var pieceOfEquipment in runtime.myLists.Items[0].ArmorSlotContains)
            {
                Console.WriteLine(runtime.myLists.ArmorItem[i].Position);
                //i++;
                //Console.ReadLine();
                /*
                if (pieceOfEquipment.Position == 0)
                {
                    Console.Write("Head: ");
                }
                else if (pieceOfEquipment.Position == 1)
                {
                    Console.Write("Neck: ");
                }
                else if (pieceOfEquipment.Position == 2)
                {
                    Console.Write("Shoulders: ");
                }
                else if (pieceOfEquipment.Position == 3)
                {
                    Console.Write("Torso: ");
                }
                else if (pieceOfEquipment.Position == 4)
                {
                    Console.Write("Arms: ");
                }
                else if (pieceOfEquipment.Position == 5)
                {
                    Console.Write("Hands: ");
                }
                else if (pieceOfEquipment.Position == 6)
                {
                    Console.Write("Legs: ");
                }
                else if (pieceOfEquipment.Position == 7)
                {
                    Console.Write("Feet: ");
                }*/
                Console.WriteLine(pieceOfEquipment.ArmorName);
            }

            Console.WriteLine("Do you want to remove something? (y/n)");
            string input = Console.ReadLine().ToLower();

            if (input == "y")
            {
                EquipmentRemover(wornEquipment, runtime);
            }
        }

        private void EquipmentRemover(Worn wornEquipment, Runtime runtime)
        {
            Console.WriteLine();
            Console.WriteLine("Which equipment would you like to remove?");
            Console.WriteLine("(Head, Neck, Shoulders, Torso, Arms, Hands, Legs, Feet)");
            string input = Console.ReadLine().ToLower();

            if (input == "head")
            {
                wornEquipment.ArmorName = "Empty";
            }
        }
    }
}
