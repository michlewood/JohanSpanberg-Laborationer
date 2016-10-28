using Labb_6___DungeonKryper.Other_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___DungeonKryper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Runtime runtime = new Labb_6___DungeonKryper.Runtime();
            PlayerControls playerControls = new PlayerControls();
            runtime.Start(runtime, playerControls);
        }
    }
}
