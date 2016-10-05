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

        public static void FileFetcher() // För att ladda en fil
        {
            bool filenameExceptionHandler = true;
            while (true)
            {
                bool fileNameController = true;
                while (fileNameController)
                {
                    Menus.FileSelector(); // Visar en prompt för användaren att ange filnamn.
                    fileName = Console.ReadLine(); // Lagrar användarens filnamn i en int.
                    if (fileName.Length < 3)
                    { // Om användaren skriver mindre än tre tecken i filnamnet.
                        Console.WriteLine("Filename length needs to be at least 3 letters. Try again.");
                    }
                    else
                        break;
                }

                try
                { // Kontrollerar om filen faktiskt finns. Om den finns så hämtas filens innehåll och lagras i Arrays.Combined.
                    Arrays.Combined = File.ReadAllLines(folderPath + @"\" + fileName + ".txt");
                }
                catch (FileNotFoundException)
                { // Om filen inte finns.
                    Console.WriteLine("The file you specified could not be found. Try again.");
                }

                ListLength = Arrays.Combined.Length; // Lagrar längden på den kombinerade arrayen i en int.

                Arrays.EmptyChecker(); // Metod för att kontrollera var första tomma plats är.
                Arrays.ArrayDiscombiner(); // Delar upp och uppdaterar de individuella arrayerna.

                filenameExceptionHandler = false; // Loopar om ett fel uppstår vid inhämtning av filnamn.

                Console.WriteLine("File {0}.txt loaded.", fileName); // Visar bekräftelse på att filen hämtats.
                Console.WriteLine("Press enter to return to main menu.");
                Console.ReadLine();
                break;
            }

        }

        public static void FileSaver() // För att spara till fil.
        {
            bool fileNameController = true;
            while (fileNameController)
            {
                Menus.FileSelector(); // Visar prompt för filnamnsval

                saveFileName = Console.ReadLine();
                if (saveFileName.Length < 3) // Om användaren anger ett filnamn med mindre än tre bokstäver.
                {
                    Console.WriteLine("Filename length needs to be at least 3 letters. Try again.");
                }
                else
                    break;
            } // Sparar ned filen.
            File.WriteAllLines(folderPath + @"\" + saveFileName + ".txt", Arrays.Combined);
        }
    }
}
