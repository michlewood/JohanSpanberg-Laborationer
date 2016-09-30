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

        public static int EmptyPosition
        {
            get { return emptyPosition; }
            set { emptyPosition = value; }
        }

        static string artistInput;
        static string albumInput;
        static string yearInput;
        static string[] artist = new string[33];
        public static string[] Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        static string[] album = new string[33];

        public static string[] Album
        {
            get { return album; }
            set { album = value; }
        }

        static string[] year = new string[33];

        public static string[] Year
        {
            get { return year; }
            set { year = value; }
        }

        static string[] combined = new string[99];

        public static string[] Combined
        {
            get { return combined; }
            set { combined = value; }
        }

        public static void ArrayDiscombiner()
        {
            for (int i = 0; i < FileHandler.ListLength / 3; i++)
            {
                Artist[i] = Combined[i * 3];
                Album[i] = Combined[i * 3 + 1];
                Year[i] = Combined[i * 3 + 2];
            }
        }

        public static void CombinedArrayShower()
        {
            Console.Clear();
            EmptyChecker();
            Console.WriteLine("You currently have {0} songs in your list: ", EmptyPosition);
            Console.WriteLine("---");

            for (int i = 0; i < artist.Length / 3; i++)
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
                    Console.WriteLine((i + 1) + ". " + Artist[i] + " - " + Album[i] + " - " + Year[i]);
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
            Console.WriteLine("Saving {0} - {1} - {2} to position {3}", artistInput, albumInput, yearInput, emptyPosition + 1);
            combined[emptyPosition * 3] = artistInput;
            combined[emptyPosition * 3 + 1] = albumInput;
            combined[emptyPosition * 3 + 2] = yearInput;
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
            Combined[arrayRemoveChoice * 3] = string.Empty;
            Combined[arrayRemoveChoice * 3 + 1] = string.Empty;
            Combined[arrayRemoveChoice * 3 + 2] = string.Empty;

            int arraySorter = arrayRemoveChoice * 3;

            for (int i = arraySorter; i < Combined.Length - 1; i++)
            {
                if (string.IsNullOrEmpty(Combined[i + 3]))
                {
                    break;
                }
                else
                {
                    string tempCombine = Combined[i + 3];
                    Combined[i] = tempCombine;
                    Combined[i + 3] = string.Empty;
                }
            }
            ArrayDiscombiner();
            Console.WriteLine("Done. Removed {0}.", arrayRemoveChoice + 1);
            Console.ReadLine();
        }

        public static void ArrayEditor()
        {
            throw new NotImplementedException(); // Inte ännu implementerat.
        }

        public static void ArrayDetailEditor()
        {
            try
            {
                Menus.EditDetailChoice = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please only use numbers between (1-3)");
            }

            if (Menus.EditDetailChoice < 1 || Menus.EditDetailChoice > 3)
            {
                Console.WriteLine("Please only use numbers between (1-3)");
            }
            else
            {
                Menus.EditDetailChoiceController = false;
            }

            string chosenEdit = "";
            if (Menus.EditDetailChoice == 1)
            {
                chosenEdit = Arrays.Artist[Menus.EditChoice - 1];
            }
            else if (Menus.EditDetailChoice == 2)
            {
                chosenEdit = Arrays.Album[Menus.EditChoice - 1];
            }
            else
                chosenEdit = Arrays.Year[Menus.EditChoice - 1];

            string chosenEditTemporary = chosenEdit;
            Console.WriteLine("You have chosen to edit: {0}", chosenEdit);
            Console.WriteLine(" ");
            Console.Write("What would you like it to say instead: ");
            chosenEdit = Console.ReadLine();

            if (Menus.EditDetailChoice == 1)
            {
                Arrays.Artist[Menus.EditChoice - 1] = chosenEdit;
            }
            else if (Menus.EditDetailChoice == 2)
            {
                Arrays.Album[Menus.EditChoice - 1] = chosenEdit;
            }
            else
                Arrays.Year[Menus.EditChoice - 1] = chosenEdit;
            Console.WriteLine("Okay. Exchanging {0} to {1}", chosenEditTemporary, chosenEdit);
            Console.ReadLine();
            Menus.EditDetailChoiceController = false;
            return;
        }
    }
}
