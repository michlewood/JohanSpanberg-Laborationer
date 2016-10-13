using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArvochPolymorfism2
{
    public class Student : Person
    {
        public string Class { get; set; }

        public override string Introduction()
        {
            return String.Format ("{0} Jag går i {1}.", base.Introduction(), Class);
        }
    }
}