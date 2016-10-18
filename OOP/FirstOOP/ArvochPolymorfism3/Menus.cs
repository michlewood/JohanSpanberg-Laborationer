using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvochPolymorfism3
{
    class Menus
    {
        public static void PrintMainMenu()
        {
            Console.WriteLine("1. Add animal");
            Console.WriteLine("2. Remove Animal");
            Console.WriteLine("3. Show Animals");
            Console.WriteLine("4. Exit");
        }
        public static void PrintMainType()
        {
            Console.WriteLine("1. Show Mammals");
            Console.WriteLine("2. Show Insect");
            Console.WriteLine("3. Show Birds");
            Console.WriteLine("4. Show Reptiles");
        }
        public static void PrintMammals()
        {
            Console.WriteLine("1. Dog");
            Console.WriteLine("2. Horse");
        }
        public static void PrintInsects()
        {
            Console.WriteLine("1. Ant");
            Console.WriteLine("2. Mosquito");
        }
        public static void PrintBirds()
        {
            Console.WriteLine("1. Eagle");
            Console.WriteLine("2. Crow");
        }
        public static void PrintReptiles()
        {
            Console.WriteLine("1. Snake");
            Console.WriteLine("2. Lizard");
        }
    }
}
