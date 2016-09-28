using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborationerGP
{
    class Menus
    {
        public static bool MainMenu()
        {
            int mainMenuSwitch = 0;
            bool mainMenuExceptionHandler = true;
            while (true)
            {
                Console.WriteLine("Welcome to SongArchive.");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("---");
                Console.WriteLine("1. Import from a text-file.");
                Console.WriteLine("2. Save list to a text-file.");
                Console.WriteLine("3. Show SongArchive.");
                Console.WriteLine("4. Edit SongArchive.");
                Console.WriteLine("5. Quit SongArchive.");
                Console.WriteLine("---");
                Console.Write("Enter Selection: ");

                try
                {
                    mainMenuSwitch = int.Parse(Console.ReadLine());
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("You can only use 1, 2, 3, 4 or 5. Try again.");
                    Console.ReadLine();
                    Console.Clear();
                }

                switch (mainMenuSwitch)
                {
                    case 1: FileHandler.FileFetcher(); break;
                    case 2: FileHandler.FileSaver(); break;
                    case 3: mainMenuExceptionHandler = false; Arrays.CombinedArrayShower(); break;
                    case 4:
                    case 5: Environment.Exit(0); break;
                    default: break;
                }
            }

        }
        public static void FileSelector()
        {
            Console.Write("Enter filename: ");
        }
    }
}
