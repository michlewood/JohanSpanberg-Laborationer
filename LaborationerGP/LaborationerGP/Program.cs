using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LaborationerGP
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Title = "SongArchive 2.0";
                Console.OutputEncoding = Encoding.UTF8;
                GUI.MainMenuGUI();
            }
        }
    }
}
