using System;

namespace LaborationerGP
{
    class GUI
    {
        public static void FileEditorMenu()
        {
            bool fileEditorMenuGuiLoop = true;
            while (fileEditorMenuGuiLoop)
            {
                CleanUp(); // Rensar formateringar
                Console.TreatControlCAsInput = false; // För att göra en exitmetod som rensar upp istället för att bara stänga.
                Console.CancelKeyPress += new ConsoleCancelEventHandler(BreakHandler); // Används tillsammans med ovanstående.
                Console.CursorVisible = false; // Döljer användarens input på tangentbordet.*/
                Console.Clear(); // Rensar gränssnittet.


                string[] fileEditorMenuChoice = { "", "", "", "", }; // Skapar en string för menyn

                fileEditorMenuChoice[0] = "Name(" + Arrays.Name[Menus.EditChoice - 1] + ")";
                fileEditorMenuChoice[1] = "Artist(" + Arrays.Artist[Menus.EditChoice - 1] + ")";
                fileEditorMenuChoice[2] = "Album(" + Arrays.Album[Menus.EditChoice - 1] + ")";
                fileEditorMenuChoice[3] = "Year(" + Arrays.Year[Menus.EditChoice - 1] + ")";


                WriteColorString("Choose with ↑/↓ and enter", 34, 10, ConsoleColor.Black, ConsoleColor.White); // Förklaring för användaren
                int choice = ChooseListBoxItem(fileEditorMenuChoice, 34, 3, ConsoleColor.Blue, ConsoleColor.White); // Lagrar vilket val användaren gör

                if (fileEditorMenuChoice[choice - 1] == "Name(" + Arrays.Name[Menus.EditChoice - 1] + ")")
                { // Om användaren väljer valet som matchar ovanstående
                    Menus.EditDetailChoice = 1;
                    Arrays.ChosenEdit = Arrays.Name[Menus.EditChoice - 1];
                    fileEditorMenuGuiLoop = false;
                    Arrays.ArrayDetailEditor();
                }
                else if (fileEditorMenuChoice[choice - 1] == "Artist(" + Arrays.Artist[Menus.EditChoice - 1] + ")")
                {
                    Menus.EditDetailChoice = 2;
                    Arrays.ChosenEdit = Arrays.Artist[Menus.EditChoice - 1];
                    fileEditorMenuGuiLoop = false;
                    Arrays.ArrayDetailEditor();
                }
                else if (fileEditorMenuChoice[choice - 1] == "Album(" + Arrays.Album[Menus.EditChoice - 1] + ")")
                {
                    Menus.EditDetailChoice = 3;
                    Arrays.ChosenEdit = Arrays.Album[Menus.EditChoice - 1];
                    fileEditorMenuGuiLoop = false;
                    Arrays.ArrayDetailEditor();
                }
                else if (fileEditorMenuChoice[choice - 1] == "Year(" + Arrays.Year[Menus.EditChoice - 1] + ")")
                {
                    Menus.EditDetailChoice = 4;
                    Arrays.ChosenEdit = Arrays.Year[Menus.EditChoice - 1];
                    fileEditorMenuGuiLoop = false;
                    Arrays.ArrayDetailEditor();
                }

            }

        }

        static void EditorMenuGUI()
        {
            bool editorMenuGuiLoop = true;
            while (editorMenuGuiLoop)
            {
                CleanUp(); // Rensar formateringar
                Console.TreatControlCAsInput = false; // För att göra en exitmetod som rensar upp istället för att bara stänga.
                Console.CancelKeyPress += new ConsoleCancelEventHandler(BreakHandler); // Används tillsammans med ovanstående.
                Console.CursorVisible = false; // Döljer användarens input på tangentbordet.*/
                Console.Clear(); // Rensar gränssnittet.


                string[] editorMenuChoice = { "Add to the SongArchive", "", "", "Return to main menu", }; // Skapar en string för menyn

                if (!string.IsNullOrEmpty(Arrays.Combined[0])) // Om albumlistan har ett innehåll.
                {
                    editorMenuChoice[0] = "Add to the SongArchive";
                    editorMenuChoice[1] = "Remove from the SongArchive";
                    editorMenuChoice[2] = "Edit an entry in the SongArchive";
                    editorMenuChoice[3] = "Return to main menu";
                }

                WriteColorString("Choose with ↑/↓ and enter", 34, 10, ConsoleColor.Black, ConsoleColor.White); // Förklaring för användaren
                int choice = ChooseListBoxItem(editorMenuChoice, 34, 3, ConsoleColor.Blue, ConsoleColor.White); // Lagrar vilket val användaren gör

                if (editorMenuChoice[choice - 1] == "Add to the SongArchive")
                { // Om användaren väljer valet som matchar ovanstående
                    CleanUp(); Arrays.ArrayAdder();
                }
                else if (editorMenuChoice[choice - 1] == "Remove from the SongArchive")
                {
                    CleanUp(); Arrays.ArrayRemover();
                }
                else if (editorMenuChoice[choice - 1] == "Edit an entry in the SongArchive")
                {
                    //CleanUp(); FileEditorMenu();
                    CleanUp(); Menus.EditorFileEditMenu();
                }
                else if (editorMenuChoice[choice - 1] == "Return to main menu")
                {
                    CleanUp();
                    editorMenuGuiLoop = false;
                    return;
                }

                //CleanUp(); // Rensar all formatering
            }

        }

        public static void MainMenuGUI()
        {
            Console.TreatControlCAsInput = false;
            Console.CancelKeyPress += new ConsoleCancelEventHandler(BreakHandler);
            Console.Clear();
            Console.CursorVisible = false;

            string[] mainMenuChoice = { "Import from a text-file", "Save list to a text-file", "Show SongArchive", "Edit SongArchive", "Quit SongArchive" };

            WriteColorString("Choose with ↑/↓ and enter", 34, 10, ConsoleColor.Black, ConsoleColor.White);
            int choice = ChooseListBoxItem(mainMenuChoice, 34, 3, ConsoleColor.Blue, ConsoleColor.White);

            if (mainMenuChoice[choice - 1] == "Quit SongArchive")
            {
                CleanUp(); Environment.Exit(0);
            }
            else if (mainMenuChoice[choice - 1] == "Import from a text-file")
            {
                CleanUp(); FileHandler.FileFetcher();
            }
            else if (mainMenuChoice[choice - 1] == "Save list to a text-file")
            {
                CleanUp(); FileHandler.FileSaver();
            }
            else if (mainMenuChoice[choice - 1] == "Show SongArchive")
            {
                CleanUp(); Arrays.CombinedArrayShower(); Console.WriteLine("Press enter to return to the main menu."); Console.ReadLine();
            }
            else if (mainMenuChoice[choice - 1] == "Edit SongArchive")
            {
                CleanUp(); EditorMenuGUI();
            }


        }

        private static int ChooseListBoxItem(string[] stringItems, int ucol, int urow, ConsoleColor back, ConsoleColor fore)
        {
            int numberOfItemsInString = stringItems.Length; // Kollar och lagrar hur många items som finns i strängen
            int maxLength = stringItems[0].Length; // Kollar och lagrar längden på strängen
            for (int i = 1; i < numberOfItemsInString; i++) // For-loop för att formatera storleken på bredden på listboxen
            {
                if (stringItems[i].Length > maxLength)
                {
                    maxLength = stringItems[i].Length;
                }
            }
            int[] rightSpaces = new int[numberOfItemsInString]; // Hur mycket utrymme som behövs till höger
            for (int i = 0; i < numberOfItemsInString; i++)
            {
                rightSpaces[i] = maxLength - stringItems[i].Length + 1; // For-loop för att formatera längden på listboxen
            }
            int lcol = ucol + maxLength + 3; // För att färglägga rätt antal kolumner
            int lrow = urow + numberOfItemsInString + 1; // För att färglägga rätt antal rader
            DrawMenuBox(ucol, urow, lcol, lrow, back, fore, true); // Ritar upp rutan.
            WriteColorString(" " + stringItems[0] + new string(' ', rightSpaces[0]), ucol + 1, urow + 1, fore, back);
            for (int i = 2; i <= numberOfItemsInString; i++)
            { // Formaterar text i textrutan
                WriteColorString(stringItems[i - 1], ucol + 2, urow + i, back, fore);
            }
            ConsoleKeyInfo cki; // För att ta emot knapptryck istället för text
            char key; // För att lagra vilken knapp som tryckts
            int choice = 1; // Integern för att lagra användarens namn.

            while (true)
            {
                cki = Console.ReadKey(true); // Läser av vilken knapp som tryckts av användaren
                key = cki.KeyChar; // Lagrar vilken knapp som tryckts enligt en charmap
                if (key == '\r') // För att se om användaren väljer menyvalet 
                {
                    return choice;
                }
                else if (cki.Key == ConsoleKey.DownArrow) // Om användaren trycker på nedåtknappen
                { // Färglägger den nya strängen och återställer den föregående strängen
                    WriteColorString(" " + stringItems[choice - 1] + new string(' ', rightSpaces[choice - 1]), ucol + 1, urow + choice, back, fore);
                    if (choice < numberOfItemsInString) // Om valet är mindre än listans längd
                    {
                        choice++; // Lägger till på choice-integern
                    }
                    else
                    { // Annars återgår vi till toppen av listan
                        choice = 1;
                    }
                    WriteColorString(" " + stringItems[choice - 1] + new string(' ', rightSpaces[choice - 1]), ucol + 1, urow + choice, fore, back);
                }
                else if (cki.Key == ConsoleKey.UpArrow) // Gör samma som ovan fast om användaren trycker uppåt på knapparna
                {
                    WriteColorString(" " + stringItems[choice - 1] + new string(' ', rightSpaces[choice - 1]), ucol + 1, urow + choice, back, fore);
                    if (choice > 1)
                    {
                        choice--;
                    }
                    else
                    {
                        choice = numberOfItemsInString;
                    }
                    WriteColorString(" " + stringItems[choice - 1] + new string(' ', rightSpaces[choice - 1]), ucol + 1, urow + choice, fore, back);
                }
            }
        }

        private static void DrawMenuBox(int ucol, int urow, int lcol, int lrow, ConsoleColor back, ConsoleColor fore, bool fill)
        { // Metod för att rita ut menyrutan
            const char Horizontal = '\u2500'; // De tecken som alltid ska användas på denna position i rutan
            const char Vertical = '\u2502';
            const char UpperLeftCorner = '\u250c';
            const char UpperRightCorner = '\u2510';
            const char LowerLeftCorner = '\u2514';
            const char LowerRightCorner = '\u2518';
            string fillLine = fill ? new string(' ', lcol - ucol - 1) : ""; // Bakgrundsutfyllnad
            SetColors(back, fore); // Vilka färger som ska användas

            Console.SetCursorPosition(ucol, urow); // Ritar toppen av rutan
            Console.Write(UpperLeftCorner);
            for (int i = ucol + 1; i < lcol; i++) // För att bestämma bredd på rutan
            {
                Console.Write(Horizontal); // Använder tecknet i horizontal
            }
            Console.Write(UpperRightCorner);

            for (int i = urow + 1; i < lrow; i++) // Ritar sidorna av rutan
            {
                Console.SetCursorPosition(ucol, i);
                Console.Write(Vertical); // Använder tecknet i vertical
                if (fill) Console.Write(fillLine); // Använder utfyllnadstecknet
                Console.SetCursorPosition(lcol, i); // Flyttar markören
                Console.Write(Vertical); // Använder vertical
            }

            Console.SetCursorPosition(ucol, lrow);
            Console.Write(LowerLeftCorner);
            for (int i = ucol + 1; i < lcol; i++) // Ritar botten av rutan
            {
                Console.Write(Horizontal);
            }
            Console.Write(LowerRightCorner);
        }

        private static void WriteColorString(string s, int column, int row, ConsoleColor backGround, ConsoleColor foreGround)
        { // Metod för att visa nuvarande val i menyn
            SetColors(backGround, foreGround);
            Console.SetCursorPosition(column, row);
            Console.Write(s);
        }

        private static void SetColors(ConsoleColor back, ConsoleColor fore)
        { // För att ställa in färg på konsollen
            Console.BackgroundColor = back;
            Console.ForegroundColor = fore;
        }

        public static void CleanUp()
        { // Rensar upp efter menyerna
            Console.ResetColor();
            Console.CursorVisible = true;
            Console.Clear();
        }

        private static void BreakHandler(object sender, ConsoleCancelEventArgs args)
        {
            // Rensar upp om användaren använder ctrl+c.
            CleanUp();
        }
    }
}