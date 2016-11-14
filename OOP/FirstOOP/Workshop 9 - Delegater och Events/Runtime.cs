using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_9___Delegater_och_Events.Filters;
using Workshop_9___Delegater_och_Events.Managers;

namespace Workshop_9___Delegater_och_Events
{
    class Runtime
    {
        public void Start()
        {
            PersonManager manager = new PersonManager();

            PersonFilter isOldFilter = PersonFilters.IsOld;
            PersonFilter isYoungFilter = PersonFilters.IsYoung;
            PersonFilter nameStartsWithAFilter = PersonFilters.NameStartsWithA;

            Console.WriteLine("Old people: ");
            manager.PrintWhere(isOldFilter);


            Console.WriteLine("\nYoung people: ");
            manager.PrintWhere(isYoungFilter);


            Console.WriteLine("\nNames that start with an A:");
            manager.PrintWhere(nameStartsWithAFilter);

            Console.WriteLine("\nNames that are longer than 4 letters:");
            manager.PrintWhere(person => person.Name.Length >= 5);
        }
    }
}