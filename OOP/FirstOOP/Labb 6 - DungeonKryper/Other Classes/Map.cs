using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___DungeonKryper.Other_Classes
{
    class Map
    {
        public string mapstringNNW { get; set; }
        public string mapstringNN { get; set; }
        public string mapstringNNE { get; set; }
        public string mapstringNW { get; set; }
        public string mapstringN { get; set; }
        public string mapstringNE { get; set; }
        public string mapstringW { get; set; }
        public string mapstringC { get; set; }
        public string mapstringE { get; set; }
        public string mapstringSW { get; set; }
        public string mapstringS { get; set; }
        public string mapstringSE { get; set; }
        public string mapstringSSW { get; set; }
        public string mapstringSS { get; set; }
        public string mapstringSSE { get; set; }


        internal void ShowMap()
        {

            Console.WriteLine(" {0}{1}{2} ",  mapstringNNW, mapstringNN, mapstringNNE);
            Console.WriteLine(" {0}{1}{2} ",  mapstringNW, mapstringN, mapstringNE);
            Console.WriteLine(" {0}{1}{2} ",  mapstringW, mapstringC, mapstringE);
            Console.WriteLine(" {0}{1}{2} ",  mapstringSW, mapstringS, mapstringSE);
            Console.WriteLine(" {0}{1}{2} ",  mapstringSSW, mapstringSS, mapstringSSE);
        }
    }
}
