using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArvochPolymorfism2
{
    public abstract class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string City { get; set; }

        public virtual string Introduction()
        {
            return String.Format("Jag heter {0}, är {1} år gammal och bor i {2}.", Name, Age, City);
        }
    }
}