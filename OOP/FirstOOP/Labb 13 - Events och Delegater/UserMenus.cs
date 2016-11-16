using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_13___Events_och_Delegater
{
    class UserMenus
    {
        public static void MainMenu()
        {
            Console.WriteLine("Welcome to waretracker.");
            Console.WriteLine("---");
            Console.WriteLine("1. Show products");
            Console.WriteLine("2. Add product");
            Console.WriteLine("3. Quit program");
            Console.WriteLine("---");
        }

        public static void FilterMenu()
        {
            Console.WriteLine("1. Show Cheap products");
            Console.WriteLine("2. Show Old products");
            Console.WriteLine("3. Show Fresh products");
            Console.WriteLine("4. Return to main menu");
        }
    }
}
