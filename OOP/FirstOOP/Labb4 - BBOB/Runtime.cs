using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4___BBOB
{
    class Runtime
    {
        public static int TotalInStock { get; set; }
        public static int UsedStock { get; set; }
        public static int NewStock { get; set; }

        public void Start()
        {
            Console.WriteLine("Hej");
            Lists lists = new Lists();
            MenuGUI.MainMenu(lists);
        }
    }
}
