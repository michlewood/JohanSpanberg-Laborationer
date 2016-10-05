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
            #region Variabler
        static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        // För att ta reda på Mina Dokument och lagra denna i en string.

        static int listLength;
        static string fileName;
        static string saveFileName;

        public static int ListLength
        {
            get { return listLength; }
            set { listLength = value; }
        }
            #endregion

        public static void FileFetcher() // För att ladda en fil
        {
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
                    {
                        try
                        { // Kontrollerar om filen faktiskt finns. Om den finns så hämtas filens innehåll och lagras i Arrays.Combined.
                            Arrays.Combined = File.ReadAllLines(folderPath + @"\" + fileName + ".txt");
                            fileNameController = false;
                        }
                        catch (FileNotFoundException)
                        { // Om filen inte finns.
                            Console.WriteLine("The file you specified could not be found. Try again.");
                        }
                    }
                }

                ListLength = Arrays.Combined.Length; // Lagrar längden på den kombinerade arrayen i en int.

                Arrays.EmptyChecker(); // Metod för att kontrollera var första tomma plats är.
                Arrays.ArrayDiscombiner(); // Delar upp och uppdaterar de individuella arrayerna.

                Console.WriteLine("File {0}.txt loaded. It was last changed {1}", fileName, File.GetLastWriteTime(folderPath + @"\" + fileName + ".txt")); // Visar bekräftelse på att filen hämtats.
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
                {
                    try
                    { // Sparar ned filen.
                        File.WriteAllLines(folderPath + @"\" + saveFileName + ".txt", Arrays.Combined);
                        fileNameController = false;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("File already exists. Use another name.");
                    }
                }
            } 

            Console.WriteLine("The file {0}.txt was saved to disk.", saveFileName);
            Console.WriteLine("Press enter to return to Main Menu.");
            Console.ReadLine();

        }
    }
}
