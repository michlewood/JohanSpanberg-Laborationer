using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb3___Biljettbokning
{
    public class AvailableMovies : Event
    {
        public string Stars{ get; set; }

        public bool RRated{ get; set; }

        public override string Presentation()
        {
            string baseContents = base.Presentation();
            return String.Format("{0}. {1} - {2}, {3}. {4} kronor om {5} dagar. {6}", Type, Name, Stars, Location, Price, Date, RRated != false ? "OBS! Barnförbjuden!" : "Barn är välkomna");
        }
    }
}