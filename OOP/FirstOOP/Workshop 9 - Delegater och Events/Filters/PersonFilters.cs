using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_9___Delegater_och_Events.Models;

namespace Workshop_9___Delegater_och_Events.Filters
{
    class PersonFilters
    {
        public static bool IsOld(Person person)
        {
            return person.Age >= 50;
        }
        public static bool IsYoung(Person person)
        {
            return person.Age < 50;
        }

        public static bool NameStartsWithA(Person person)
        {
            return person.Name[0] == 'A';
        }
    }
}
