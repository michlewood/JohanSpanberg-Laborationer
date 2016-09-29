using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborationerGP
{
    class Menus
    {
        private static int editDetailChoice;

        public static int EditDetailChoice
        {
            get { return editDetailChoice; }
            set { editDetailChoice = value; }
        }

        private static int editChoice;

        public static int EditChoice
        {
            get { return editChoice; }
            set { editChoice = value; }
        }

        private static bool editDetailChoiceController;

        public static bool EditDetailChoiceController
        {
            get { return editDetailChoiceController; }
            set { editDetailChoiceController = value; }
        }


        public static bool MainMenu() // Huvudmenyn.
        {
            int mainMenuSwitch = 0;
            bool mainMenuExceptionHandler = true;
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
                    case 1: FileHandler.FileFetcher(); break;
                    case 2: FileHandler.FileSaver(); break;
                    case 3: Arrays.CombinedArrayShower(); Console.WriteLine("Press enter to return to the main menu."); Console.ReadLine(); break;
                    case 4: Editor(); break;
                    case 5: Environment.Exit(0); break;
                    default: break;
                }
            }

        }
        public static void FileSelector()
        {
            Console.Write("Enter filename (not .txt): ");
        }
        public static void Editor()
        {
            int editorMenu = 0;
            bool editorControllerLoop = true;
            while (editorControllerLoop)
            {
                Console.Clear();
                Arrays.CombinedArrayShower();
                Console.WriteLine("What would you like to edit?");
                Console.WriteLine("1. Add to the SongArchive.");
                Console.WriteLine("2. Remove from the SongArchive.");
                Console.WriteLine("3. Edit an entry in the SongArchive.");
                Console.WriteLine("4. Return to main menu.");
                Console.WriteLine("---");
                Console.Write("Enter choice: ");
                try
                {
                    editorMenu = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("You need to select 1, 2, 3 or 4.");
                }
                switch (editorMenu)
                {
                    case 1: Arrays.ArrayAdder(); break;
                    case 2: Arrays.ArrayRemover(); break;
                    case 3: EditorFileEditMenu(); break;
                    case 4: return;
                    default: break;
                }
            }
           
        }
        public static void EditorFileEditMenu()
        {
            Arrays.CombinedArrayShower();
            Arrays.EmptyChecker(); // Ser till så att emptyPosition är uppdaterad innan metoden körs.
            Console.WriteLine(" ");
            bool editChoiceController = true;
            while (editChoiceController)
            {
                Console.Write("Which entry would you like to edit (1-{0}): ", Arrays.EmptyPosition);
                try
                {
                    editChoice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please only use numbers between (1-{0})", Arrays.EmptyPosition);
                }

                if (editChoice < 1 || editChoice > Arrays.EmptyPosition) // Om användaren försöker gå utanför möjligheterna.
                {
                    Console.WriteLine("You have to chose a number between (1-{0})", Arrays.EmptyPosition);
                }
                else
                {
                    editChoiceController = false;
                }
            }

            
            EditDetailChoiceController = true;
            while (EditDetailChoiceController)
            {
                Console.WriteLine("What would you like to edit:");
                Console.WriteLine("1. Artist ({0})", Arrays.Artist[editChoice - 1]);
                Console.WriteLine("2. Album ({0})", Arrays.Album[editChoice - 1]);
                Console.WriteLine("3. Year ({0})", Arrays.Year[editChoice - 1]);
                Console.WriteLine("---");
                Console.Write("Enter choice: ");
                Arrays.ArrayDetailEditor();
            }
                
        }
    }
}
