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
                    case 1: FileHandler.FileFetcher(); break; // För att hämta en fil.
                    case 2: FileHandler.FileSaver(); break; // För att spara en fil.
                    case 3: Arrays.CombinedArrayShower(); Console.WriteLine("Press enter to return to the main menu."); Console.ReadLine(); break; // För att visa nuvarande vinylsamling
                    case 4: Editor(); break; // För att redigera vinylsamlingen.
                    case 5: Environment.Exit(0); break; // För att stänga programmet.
                    default: break;
                }
            }

        }

        public static void FileSelector()
        {
            Console.Write("Enter filename (not .txt): "); // Ber användaren välja filnamn.
        }

        public static void Editor()
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
                        case 3: EditorFileEditMenu(); break;
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

        public static void EditorFileEditMenu()
        {
            Arrays.CombinedArrayShower(); // För att visa innehållet i albumlistan
            Arrays.ArrayDiscombiner(); // För att dela upp huvudarrayen till fyra arrays,
            Arrays.EmptyChecker(); // Ser till så att emptyPosition är uppdaterad innan metoden körs.
            Console.WriteLine(" ");
            bool editChoiceController = true;
            while (editChoiceController)
            {
                if (string.IsNullOrEmpty(Arrays.Combined[4])) // Om det bara finns ett entry i albumlistan
                {
                    Console.Write("Which entry would you like to edit(1): ");
                }
                else // Om det finns mer än ett entry i albumlistan.
                {
                    Console.Write("Which entry would you like to edit (1-{0}): ", Arrays.EmptyPosition);
                }

                try // För att se så att användaren använder siffror.
                {
                    editChoice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please only use numbers.");
                }


                if (editChoice < 1 && string.IsNullOrEmpty(Arrays.Combined[4]) || string.IsNullOrEmpty(Arrays.Combined[4]) && editChoice > Arrays.EmptyPosition) // Om användaren försöker gå utanför möjligheterna.
                { // Om editchoice är mindre än 1 och huvudarrayen bara innehåller ett entry, eller om huvudarrayen bara innehåller ett entry och användarvalet är större än albumsamlingens sista entry.
                    Console.WriteLine("You have to chose a number (1)", Arrays.EmptyPosition);
                    Console.WriteLine();
                }
                else if (editChoice < 1 && !string.IsNullOrEmpty(Arrays.Combined[4]) || !string.IsNullOrEmpty(Arrays.Combined[4]) && editChoice > Arrays.EmptyPosition)
                { // Om editchoice är mindre än 1 och huvudarrayen innehåller mer än ett entry, eller om huvudarrayen innehåller mer än ett entry och användarvalet är större än albumsamlingens sista entry.
                    Console.WriteLine("You have to chose a number between (1-{0})", Arrays.EmptyPosition);
                    Console.WriteLine();
                }

                else
                {
                    editChoiceController = false;
                }
            }

            EditDetailChoiceController = true;
            while (EditDetailChoiceController)
            { // Visar redigeringsmenyn.
                Console.WriteLine("What would you like to edit:");
                Console.WriteLine("1. Name ({0})", Arrays.Name[editChoice - 1]);
                Console.WriteLine("2. Artist ({0})", Arrays.Artist[editChoice - 1]);
                Console.WriteLine("3. Album ({0})", Arrays.Album[editChoice - 1]);
                Console.WriteLine("4. Year ({0})", Arrays.Year[editChoice - 1]);
                Console.WriteLine("---");
                Console.Write("Enter choice: ");
                Arrays.ArrayDetailEditor();
            }
        }
    }
}
