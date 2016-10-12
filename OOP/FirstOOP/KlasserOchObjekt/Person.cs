using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasserOchObjekt
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public Person()
        {
        }

        public Person(string name, int age, string city)
        {
            Name = name;
            Age = age;
            City = city;
        }

        public string Introduction()
        {
            return String.Format("Hej! Jag heter {0}. Jag är {1} år gammal och kommer ifrån {2}", Name, Age, City);
        }
    }
}
