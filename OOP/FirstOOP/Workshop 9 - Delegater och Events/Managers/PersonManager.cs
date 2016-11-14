using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_9___Delegater_och_Events.Models;

namespace Workshop_9___Delegater_och_Events.Managers
{
    class PersonManager
    {
        public List<Person> People { get; set; }

        public PersonManager()
        {
            People = new List<Person>
            {
                new Person { Name = "Johan", Age = 33 },
                new Person { Name = "Sara", Age = 34 },
                new Person { Name = "Danbert", Age = 69 },
                new Person { Name = "Rogert", Age = 19 },
                new Person { Name = "Siv", Age = 55 },
                new Person { Name = "Anna", Age = 54 },
            };
        }
        public void PrintWhere(PersonFilter filter)
        {
            foreach (var person in People)
            {
                if (filter(person))
                    Console.WriteLine(person.Name);
            }
        }
    }
}
