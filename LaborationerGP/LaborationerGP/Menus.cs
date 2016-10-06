using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborationerGP
{
    class Menus
    {
            #region Variabler
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
        #endregion

        public static void FileSelector() // Filvalsprompt 
        {
            Console.Write("Enter filename (not .txt): "); // Ber användaren välja filnamn.
        }

        public static void EditorFileEditMenu() // Undermeny till redigeringsmenyn
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
                    Console.Write("Which entry would you like to edit (1): ");
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
                    
                }

                if (editChoice < 1 && string.IsNullOrEmpty(Arrays.Combined[4]) || string.IsNullOrEmpty(Arrays.Combined[4]) && editChoice > Arrays.EmptyPosition) // Om användaren försöker gå utanför möjligheterna.
                { // Om editchoice är mindre än 1 och huvudarrayen bara innehåller ett entry, eller om huvudarrayen bara innehåller ett entry och användarvalet är större än albumsamlingens sista entry.
                    Console.WriteLine("You have to chose a number (1)");
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
            GUI.CleanUp(); GUI.FileEditorMenu();
        }
    }
}
