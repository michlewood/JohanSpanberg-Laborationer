using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborationerGP
{
    class redundant // Finns kvar utifall att jag vill reversera tillbaka till tidigare ändringar
    {
        public static void Editor() // Redigeringsmenyn
        {
            int editorMenu = 0; // Gör en val-int.
            bool editorControllerLoop = true; // För kontroll av menyn.
            while (editorControllerLoop)
            {
                Console.Clear(); // Rensar konsollen från tidigare text.
                Arrays.CombinedArrayShower();
                Console.WriteLine("What would you like to edit?");

                if (!string.IsNullOrEmpty(Arrays.Combined[0])) // Om Albumlistan har ett innehåll.
                {
                    Console.WriteLine("1. Add to the SongArchive.");
                    Console.WriteLine("2. Remove from the SongArchive.");
                    Console.WriteLine("3. Edit an entry in the SongArchive.");
                    Console.WriteLine("4. Return to main menu.");
                    Console.WriteLine("---");
                }
                else // Om albumlistan är tom.
                {
                    Console.WriteLine("1. Add to the SongArchive.");
                    Console.WriteLine("2. Return to main menu.");
                    Console.WriteLine("---");
                }
                Console.Write("Enter choice: ");
                try // För att se så att användaren använder siffror.
                {
                    editorMenu = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("You need to select 1, 2, 3 or 4.");
                }
                if (!string.IsNullOrEmpty(Arrays.Combined[0])) // Om albumlistan har ett innehåll.
                {
                    switch (editorMenu)
                    {
                        case 1: Arrays.ArrayAdder(); break;
                        case 2: Arrays.ArrayRemover(); break;
                        case 3: /*EditorFileEditMenu();*/ break;
                        case 4: return;
                        default: break;
                    }
                }
                else // Om albumlistan är tom.
                {
                    switch (editorMenu)
                    {
                        case 1: Arrays.ArrayAdder(); break;
                        case 2: return;
                        default: break;
                    }
                }
            }
        }

        public static void MenuGUIChoice()
        {
            int menuGUIChoice = 0;
            Console.WriteLine("1. Old");
            Console.WriteLine("2. Modern (default)");
            Console.Write("Choose design: ");
            int.TryParse(Console.ReadLine(), out menuGUIChoice);

            if (menuGUIChoice == 1)
            {
                while (true)
                {
                    MainMenu();
                }
            }
            else
            {
                while (true)
                {
                    GUI.MainMenuGUI();
                }
            }
        }


        public static bool MainMenu() // Huvudmenyn.
        {
            int mainMenuSwitch = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to SongArchive."); // Presenterar valmöjligheter.
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("---");
                Console.WriteLine("1. Import from a text-file.");
                Console.WriteLine("2. Save list to a text-file.");
                Console.WriteLine("3. Show SongArchive.");
                Console.WriteLine("4. Edit SongArchive.");
                Console.WriteLine("5. Quit SongArchive.");
                Console.WriteLine("---");
                Console.Write("Enter Selection: ");

                try // Kollar så att användaren inte försöker förstöra programmet.
                {
                    mainMenuSwitch = int.Parse(Console.ReadLine());

                }
                catch (Exception) // Om användaren försöker förstöra programmet.
                {
                    Console.WriteLine("You can only use 1, 2, 3, 4 or 5. Try again.");
                    Console.ReadLine();
                    Console.Clear();
                }

                switch (mainMenuSwitch)
                {
                    case 1: FileHandler.FileFetcher(); break; // För att hämta en fil.
                    case 2: FileHandler.FileSaver(); break; // För att spara en fil.
                    case 3: Arrays.CombinedArrayShower(); Console.WriteLine("Press enter to return to the main menu."); Console.ReadLine(); break; // För att visa nuvarande vinylsamling
                    case 4: /*Editor();*/ break; // För att redigera vinylsamlingen.
                    case 5: Environment.Exit(0); break; // För att stänga programmet.
                    default: break;
                }
            }

        }

    }
}
