using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb3___Biljettbokning
{
    public class AvailableConcerts : Event
    {
        public string Artist { get; set; }

        public bool Alcohole { get; set; }

        public override string Presentation()
        {
            string baseContents = base.Presentation();
            return String.Format("{0}. {1} - {2}, {3}. {4} kronor om {5} dagar. {6}", 
                                    Type, 
                                    Artist, 
                                    Name, 
                                    Location, 
                                    Price, 
                                    Date, 
                                    Alcohole != false ? "Alkohol får förtäras." : "Alkoholfritt!");
        }
    }
}