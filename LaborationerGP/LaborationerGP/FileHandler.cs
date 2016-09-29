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
        static string fileName;
        static string saveFileName;

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
                bool fileNameController = true;
                while (fileNameController)
                {
                    Menus.FileSelector();
                    fileName = Console.ReadLine();
                    if (fileName.Length < 3)
                    {
                        Console.WriteLine("Filename length needs to be at least 3 letters. Try again.");
                    }
                    else
                        break;
                }

                try
                {
                    Arrays.Combined = File.ReadAllLines(folderPath + @"\" + fileName + ".txt");
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("The file you specified could not be found. Try again.");
                }
                ListLength = Arrays.Combined.Length;
                Arrays.EmptyChecker();
                Arrays.ArrayDiscombiner();
                filenameExceptionHandler = false;
                Console.WriteLine("File {0}.txt loaded.", fileName);
                Console.WriteLine("Press enter to return to main menu.");
                Console.ReadLine();
                break;
            }

        }
        public static void FileSaver()
        {
            bool fileNameController = true;
            while (fileNameController)
            {
                Menus.FileSelector();
                saveFileName = Console.ReadLine();
                if (saveFileName.Length < 3)
                {
                    Console.WriteLine("Filename length needs to be at least 3 letters. Try again.");
                }
                else
                    break;
            }
            File.WriteAllLines(folderPath + @"\" + saveFileName + ".txt", Arrays.Combined);
        }

    }
}
