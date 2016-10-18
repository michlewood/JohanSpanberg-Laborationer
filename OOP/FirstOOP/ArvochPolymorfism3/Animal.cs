using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArvochPolymorfism3
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }

        public virtual string Move()
        {
            return "The animal moves around";
        }
    }
}