using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborationerGP
{
    class Arrays
    {
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
            Console.WriteLine("You currently have: ");
            Console.WriteLine("---");

            for (int i = 0; i < FileHandler.ListLength / 3; i++)
            {
                if (artist[i] == "")
                {
                    Console.WriteLine("Your list is empty. Import a list to populate it.");
                    i = Artist.Length;
                    break;
                }

                else
                {
                    Console.Write((i + 1) + ". " + Artist[i] + " - ");
                    Console.Write(Album[i] + " - ");
                    Console.WriteLine(Year[i]);
                }
                
            }
            Console.WriteLine(" ");

            return;
        }

    }
}
