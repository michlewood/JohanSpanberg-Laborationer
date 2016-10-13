using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArvochPolymorfism2
{
    public class Teacher : Person
    {
        public string Subject { get; set; }

        public override string Introduction()
        {
            return String.Format("{0} Jag lär ut {1}.", base.Introduction(), Subject);
        }
    }
}