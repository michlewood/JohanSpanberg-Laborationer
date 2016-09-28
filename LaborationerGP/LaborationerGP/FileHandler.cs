using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LaborationerGP
{
    class FileHandler
    {
        static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        static int listLength;

        public static int ListLength
        {
            get { return listLength; }
            set { listLength = value; }
        }


        public static void FileFetcher()
        {
            bool filenameExceptionHandler = true;
            while (true)
            {
                Menus.FileSelector();
                string fileName = Console.ReadLine();

                try
                {
                    Arrays.Combined = File.ReadAllLines(folderPath + @"\" + fileName);
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("The file you specified could not be found. Try again.");
                }
                ListLength = Arrays.Combined.Length;

                Arrays.ArrayDiscombiner();
                filenameExceptionHandler = false;
                break;
            }

        }
        public static void FileSaver()
        {
            Menus.FileSelector();
            string saveFileName = Console.ReadLine();
            File.WriteAllLines(folderPath + @"\" + saveFileName, Arrays.Combined);
        }

    }
}
