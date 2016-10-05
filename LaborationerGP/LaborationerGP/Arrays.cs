using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborationerGP
{
    class Arrays
    {
            #region Variabler
        static int emptyPosition;
        static string chosenEdit;
        public static int EmptyPosition
        {
            get { return emptyPosition; }
            private set { emptyPosition = value; }
        }

        static string artistInput;
        static string albumInput;
        static string yearInput;
        static string nameInput;

        static string[] artist = new string[44];
        public static string[] Artist
        {
            get { return artist; }
            private set { artist = value; }
        }

        static string[] album = new string[44];

        public static string[] Album
        {
            get { return album; }
            private set { album = value; }
        }

        static string[] year = new string[44];

        public static string[] Year
        {
            get { return year; }
            private set { year = value; }
        }

        static string[] name = new string[44];

        public static string[] Name
        {
            get { return name; }
            private set { name = value; }
        }

        static string[] combined = new string[176];

        public static string[] Combined
        {
            get { return combined; }
            set { combined = value; }
        }
            #endregion

        public static void ArrayDiscombiner() // För att spränga upp till individuella arrays
        {
            for (int i = 0; i < FileHandler.ListLength / 4; i++)
            { // En for-loop för att gå igenom hela den kombinerade listan och lagrar respektive värde i respektive array.
                Name[i] = Combined[i * 4];
                Artist[i] = Combined[i * 4 + 1]; // På plats i * 4 + 1
                Album[i] = Combined[i * 4 + 2];
                Year[i] = Combined[i * 4 + 3];
            }
        } 

        public static void CombinedArrayShower() // För att visa innehållet i albumlistan
        {
            Console.Clear(); // Rensa konsollen
            EmptyChecker(); // Uppdatera lediga platser i albumlistan
            Console.WriteLine("You currently have {0} songs in your list: ", EmptyPosition);
            Console.WriteLine("---");

            for (int i = 0; i < artist.Length / 4; i++)
            { // En for-loop som snurrar så länge i är mindre än Artist-längd delat på fyra
                if (string.IsNullOrEmpty(artist[0])) // Om index 0 är tom visas detta
                {
                    Console.WriteLine("Your list is empty. Import a list to populate it.");
                    Console.WriteLine("Or add items through the itemadder.");
                    i = artist.Length;
                    break;
                }
                else if (!string.IsNullOrEmpty(artist[i]))
                { // Om index i innehåller någonting skrivs följande ut
                    Console.WriteLine((i + 1) + ". " + Name[i] + " - " + Artist[i] + " - " + Album[i] + " - " + Year[i]);
                }
                else
                    break;

            }
            Console.WriteLine();
            return;
        } 

        public static void EmptyChecker() // För att kontrollera var det finns plats för nytt inlägg
        {
            for (int i = 0; i < artist.Length; i++)
            { // Snurrar så länge vi inte går utanför artist-längd.
                if (string.IsNullOrEmpty(artist[i]))
                { // Om indexpositionen är tom så sätts emptyposition till indexpositionen.
                    emptyPosition = i;
                    break;
                }
            }
        } 

        public static void ArrayAdder() // För att lägga till i albumlistan
        {
            EmptyChecker(); // Uppdaterar var det finns utrymme

            Console.WriteLine("We will store your data at position {0}.", emptyPosition + 1);
            Console.WriteLine("since that is empty.");
            Console.ReadLine();

            bool nameInputController = true;
            while (nameInputController)
            {
                Console.Write("The Name you would like to add: ");
                nameInput = Console.ReadLine();
                if (nameInput.Length < 3)
                { // Om valt namn är kortare än tre tecken
                    Console.WriteLine("Name needs to be at least 3 letters. Try again.");
                }
                else
                    nameInputController = false;
            }

            bool artistInputController = true;
            while (artistInputController)
            { 
                Console.Write("The Artist you would like to add: ");
                artistInput = Console.ReadLine();
                if (artistInput.Length < 3)
                { // Om artistens namn är kortare än tre tecken
                    Console.WriteLine("Artist name needs to be at least 3 letters. Try again.");
                }
                else
                    artistInputController = false;
            }

            bool albumInputController = true;
            while (albumInputController)
            {
                Console.Write("The Album you would like to add: ");
                albumInput = Console.ReadLine();
                if (albumInput.Length < 3)
                { // Om albumnamnet är mindre än tre tecken
                    Console.WriteLine("Album name needs to be at least 3 letters. Try again.");
                }
                else
                    albumInputController = false;
            }

            bool yearInputController = true;
            while (yearInputController)
            {
                Console.Write("The year it was released: ");
                yearInput = Console.ReadLine();
                if (yearInput.Length < 2)
                { // Om årtalet för albumet är kortare än två tecken.
                    Console.WriteLine("You need to enter year with two or four numbers.");
                }
                else
                    yearInputController = false;
            } // Visar en sammanfattning av vad användaren skrivit in.

            Console.WriteLine("Saving {0} - {1} - {2} - {3} to position {4}", nameInput, artistInput, albumInput, yearInput, emptyPosition + 1);
            combined[emptyPosition * 4] = nameInput; // Lagrar input på första tomma positionen
            combined[emptyPosition * 4 + 1] = artistInput;
            combined[emptyPosition * 4 + 2] = albumInput;
            combined[emptyPosition * 4 + 3] = yearInput;
            FileHandler.ListLength = Combined.Length; // Uppdaterar längden på albumlistan

            ArrayDiscombiner(); // Uppdaterar samtliga arrays.
            EmptyChecker(); // Uppdaterar tom position.

            Console.ReadLine();
        } 

        public static void ArrayRemover() // För att ta bort ur albumlistan
        {
            CombinedArrayShower(); // Visar albumlistan
            EmptyChecker(); // Uppdaterar tom position
            int arrayRemoveChoice = 0;
            bool removalController = true;
            while (removalController)
            {
                if (string.IsNullOrEmpty(Arrays.Combined[4]))
                {
                    Console.Write("The entry you want to remove (1): ");
                }
                else
                {
                    Console.Write("The entry you want to remove (1-{0}): ", EmptyPosition);
                }

                try
                { // Kontrollerar så att användaren använder siffror.
                    arrayRemoveChoice = int.Parse(Console.ReadLine());
                    removalController = false;
                }

                catch (Exception)
                {
                    Console.WriteLine("You need to use numbers.");
                }

                if (arrayRemoveChoice > emptyPosition)
                {
                    Console.WriteLine("Out of range. Choose a valid position");
                }
            }

            arrayRemoveChoice--; // För att översätta användarens input till indexposition
            Combined[arrayRemoveChoice * 4] = string.Empty;
            Combined[arrayRemoveChoice * 4 + 1] = string.Empty;
            Combined[arrayRemoveChoice * 4 + 2] = string.Empty;
            Combined[arrayRemoveChoice * 4 + 3] = string.Empty;

            int arraySorter = arrayRemoveChoice * 4; // För att göra om användarens input till indexposition

            for (int i = arraySorter; i < Combined.Length - 1; i++)
            { // Loop som snurrar så länge användarens input är mindre än längden på albumlistan
                if (string.IsNullOrEmpty(Combined[i + 4]))
                { // Om vi når slutet på filen
                    break;
                }
                else
                { // Flyttar upp varje inlägg en position.
                    string tempCombine = Combined[i + 4]; // Lagrar index + 4 i en temporär string
                    Combined[i] = tempCombine; // Sätter index till temporär
                    Combined[i + 4] = string.Empty; // Rensar index + 4
                }
            }
            ArrayDiscombiner(); // Uppdaterar enskilda arrays.
            Console.WriteLine("Done. Removed {0}.", arrayRemoveChoice + 1); // Visar bekräftelse på vad som gjorts.
            Console.ReadLine();
        }

        public static void ArrayDetailEditor() // För att redigera saker i albumlistan
        {
            bool editChoiceController = true;
            while (editChoiceController)
            {
                ArrayDiscombiner(); // Uppdaterar arrays
                try
                { // Kontrollerar så att användaren använder siffror
                    Menus.EditDetailChoice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    
                }

                switch (Menus.EditDetailChoice)
                {
                    case 1: chosenEdit = Arrays.Name[Menus.EditChoice - 1]; editChoiceController = false; break;
                    case 2: chosenEdit = Arrays.Artist[Menus.EditChoice - 1]; editChoiceController = false; break;
                    case 3: chosenEdit = Arrays.Album[Menus.EditChoice - 1]; editChoiceController = false; break;
                    case 4: chosenEdit = Arrays.Year[Menus.EditChoice - 1]; editChoiceController = false; break;
                    default: Console.WriteLine("Please only use numbers between (1-4)"); Console.Write("Enter choice: "); editChoiceController = true; break;
                }
            }

            string chosenEditTemporary = chosenEdit;
            Console.WriteLine("You have chosen to edit: {0}", chosenEdit);
            Console.WriteLine(" ");
            Console.Write("What would you like it to say instead: ");
            chosenEdit = Console.ReadLine();

            switch (Menus.EditDetailChoice)
            {
                case 1:
                    Arrays.Name[Menus.EditChoice - 1] = chosenEdit;
                    Combined[(Menus.EditChoice - 1) * 4] = Name[Menus.EditChoice - 1];
                    break;

                case 2:
                    Arrays.Artist[Menus.EditChoice - 1] = chosenEdit;
                    Combined[(Menus.EditChoice - 1) * 4 + 1] = Artist[Menus.EditChoice - 1];
                    break;
                case 3:
                    Arrays.Album[Menus.EditChoice - 1] = chosenEdit;
                    Combined[(Menus.EditChoice - 1) * 4 + 2] = Album[Menus.EditChoice - 1];
                    break;
                case 4:
                    Arrays.Year[Menus.EditChoice - 1] = chosenEdit;
                    Combined[(Menus.EditChoice - 1) * 4 + 3] = Year[Menus.EditChoice - 1];
                    break;
                default: Console.WriteLine("Please only use numbers between (1-4)"); break;
            }


            Console.WriteLine("Okay. Exchanging {0} to {1}", chosenEditTemporary, chosenEdit);
            Console.ReadLine();
            ArrayDiscombiner();
            Menus.EditDetailChoiceController = false;
            return;
        } 
    }
}
