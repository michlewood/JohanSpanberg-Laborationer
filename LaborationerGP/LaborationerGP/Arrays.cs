using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborationerGP
{
    class Arrays
    {
        static int emptyPosition;
        static string chosenEdit;
        public static int EmptyPosition
        {
            get { return emptyPosition; }
            set { emptyPosition = value; }
        }

        static string artistInput;
        static string albumInput;
        static string yearInput;
        static string nameInput;

        static string[] artist = new string[44];
        public static string[] Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        static string[] album = new string[44];

        public static string[] Album
        {
            get { return album; }
            set { album = value; }
        }

        static string[] year = new string[44];

        public static string[] Year
        {
            get { return year; }
            set { year = value; }
        }

        static string[] name = new string[44];

        public static string[] Name
        {
            get { return name; }
            set { name = value; }
        }

        static string[] combined = new string[176];

        public static string[] Combined
        {
            get { return combined; }
            set { combined = value; }
        }

        public static void ArrayDiscombiner()
        {
            for (int i = 0; i < FileHandler.ListLength / 4; i++)
            {
                Name[i] = Combined[i * 4];
                Artist[i] = Combined[i * 4 + 1];
                Album[i] = Combined[i * 4 + 2];
                Year[i] = Combined[i * 4 + 3];
            }
        }

        public static void CombinedArrayShower()
        {
            Console.Clear();
            EmptyChecker();
            Console.WriteLine("You currently have {0} songs in your list: ", EmptyPosition);
            Console.WriteLine("---");

            for (int i = 0; i < artist.Length / 4; i++)
            {
                if (string.IsNullOrEmpty(artist[0]))
                {
                    Console.WriteLine("Your list is empty. Import a list to populate it.");
                    Console.WriteLine("Or add items through the itemadder.");
                    i = artist.Length;
                    break;
                }
                else if (!string.IsNullOrEmpty(artist[i]))
                {
                    Console.WriteLine((i + 1) + ". " + Name[i] + " - " + Artist[i] + " - " + Album[i] + " - " + Year[i]);
                }
                else
                    break;

            }
            Console.WriteLine();
            return;
        }

        public static void EmptyChecker()
        {
            for (int i = 0; i < artist.Length; i++)
            {
                if (string.IsNullOrEmpty(artist[i]))
                {
                    emptyPosition = i;
                    break;
                }
            }
        }

        public static void ArrayAdder()
        {
            EmptyChecker();

            Console.WriteLine("We will store your data at position {0}.", emptyPosition + 1);
            Console.WriteLine("since that is empty.");
            Console.ReadLine();

            bool nameInputController = true;
            while (nameInputController)
            {
                Console.Write("The Name you would like to add: ");
                nameInput = Console.ReadLine();
                if (nameInput.Length < 3)
                {
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
                {
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
                {
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
                {
                    Console.WriteLine("You need to enter year with two or four numbers.");
                }
                else
                    yearInputController = false;
            }
            Console.WriteLine("Saving {0} - {1} - {2} - {3} to position {4}", nameInput, artistInput, albumInput, yearInput, emptyPosition + 1);
            combined[emptyPosition * 4] = nameInput;
            combined[emptyPosition * 4 + 1] = artistInput;
            combined[emptyPosition * 4 + 2] = albumInput;
            combined[emptyPosition * 4 + 3] = yearInput;
            FileHandler.ListLength = Combined.Length;
            ArrayDiscombiner();
            EmptyChecker();
            Console.ReadLine();
        }

        public static void ArrayRemover()
        {
            CombinedArrayShower();
            EmptyChecker();
            int arrayRemoveChoice = 0;
            bool removalController = true;
            while (removalController)
            {
                Console.Write("The entry you want to remove (1-{0}): ", EmptyPosition);
                try
                {
                    arrayRemoveChoice = int.Parse(Console.ReadLine());
                    removalController = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("You need to use numbers.");
                }
            }
            arrayRemoveChoice--;
            Combined[arrayRemoveChoice * 4] = string.Empty;
            Combined[arrayRemoveChoice * 4 + 1] = string.Empty;
            Combined[arrayRemoveChoice * 4 + 2] = string.Empty;
            Combined[arrayRemoveChoice * 4 + 3] = string.Empty;

            int arraySorter = arrayRemoveChoice * 4;

            for (int i = arraySorter; i < Combined.Length - 1; i++)
            {
                if (string.IsNullOrEmpty(Combined[i + 4]))
                {
                    break;
                }
                else
                {
                    string tempCombine = Combined[i + 4];
                    Combined[i] = tempCombine;
                    Combined[i + 4] = string.Empty;
                }
            }
            ArrayDiscombiner();
            Console.WriteLine("Done. Removed {0}.", arrayRemoveChoice + 1);
            Console.ReadLine();
        }

        public static void ArrayDetailEditor()
        {
            ArrayDiscombiner();
            try
            {
                Menus.EditDetailChoice = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please only use numbers between (1-4)");
            }

            if (Menus.EditDetailChoice < 1 || Menus.EditDetailChoice > 4)
            {
                Console.WriteLine("Please only use numbers between (1-4)");
            }
            else
            {
                Menus.EditDetailChoiceController = false;
            }


            if (Menus.EditDetailChoice == 1)
            {
                chosenEdit = Arrays.Name[Menus.EditChoice - 1];
            }
            else if (Menus.EditDetailChoice == 2)
            {
                chosenEdit = Arrays.Artist[Menus.EditChoice - 1];
            }
            else if (Menus.EditDetailChoice == 3)
            {
                chosenEdit = Arrays.Album[Menus.EditChoice - 1];
            }
            else if (Menus.EditDetailChoice == 4)
            {
                chosenEdit = Arrays.Year[Menus.EditChoice - 1];
            }
            else
                Console.WriteLine("FEL!");


            string chosenEditTemporary = chosenEdit;
            Console.WriteLine("You have chosen to edit: {0}", chosenEdit);
            Console.WriteLine(" ");
            Console.Write("What would you like it to say instead: ");
            chosenEdit = Console.ReadLine();

            if (Menus.EditDetailChoice == 1)
            {
                Arrays.Name[Menus.EditChoice - 1] = chosenEdit;
                Combined[(Menus.EditChoice - 1) * 4] = Name[Menus.EditChoice - 1];
            }
            else if (Menus.EditDetailChoice == 2)
            {
                Arrays.Artist[Menus.EditChoice - 1] = chosenEdit;
                Combined[(Menus.EditChoice - 1) * 4 + 1] = Artist[Menus.EditChoice - 1];
            }
            else if (Menus.EditDetailChoice == 3)
            {
                Arrays.Album[Menus.EditChoice - 1] = chosenEdit;
                Combined[(Menus.EditChoice - 1) * 4 + 2] = Album[Menus.EditChoice - 1];
            }
            else
            {
                Arrays.Year[Menus.EditChoice - 1] = chosenEdit;
                Combined[(Menus.EditChoice - 1) * 4 + 3] = Year[Menus.EditChoice - 1];
            }

            Console.WriteLine("Okay. Exchanging {0} to {1}", chosenEditTemporary, chosenEdit);
            Console.ReadLine();
            ArrayDiscombiner();
            Menus.EditDetailChoiceController = false;
            return;
        }
    }
}
