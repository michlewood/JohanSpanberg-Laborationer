using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WorkShop___LINQ
{

    class Runtime
    {

        public void Start()
        {
            List<Person> people = new List<Person>()
            {
                new Person {FirstName = "John",     LastName = "Fristedt",      Age = 24, City = "Stockholm"},
                new Person {FirstName = "Johan",    LastName = "Spånberg",      Age = 24, City = "Stockholm"},
                new Person {FirstName = "Niklas",   LastName = "Persson",       Age = 24, City = "Stockholm"},
                new Person {FirstName = "Anna",     LastName = "Eriksson",      Age = 24, City = "Stockholm"},
                new Person {FirstName = "John",     LastName = "Smith",         Age = 24, City = "Stockholm"},
                new Person {FirstName = "Niklas",   LastName = "Pettersson",    Age = 24, City = "Stockholm"},
                new Person {FirstName = "Nisse",    LastName = "Andersson",     Age = 24, City = "Stockholm"},
                new Person {FirstName = "John",     LastName = "Wayne",         Age = 24, City = "Stockholm"}
            };
            #region SingleOrDefault
            // Single antar att det vi söker efter är unikt. Två likadana entries kraschar.
            // SingleOrDefault kollar efter entriet och skickar vidare null om entriet inte finns.
            // Båda kraschar om entriet inte finns.

            Person singlePerson = people.SingleOrDefault(person => String.Equals(person.ToString(), "John Fristedt"));

            // ? och : är en enkel ifsats.

            // Svarskod:
            //Console.WriteLine("SingleOrDefault: {0}", 
            //    singlePerson != null ? singlePerson.ToString() : "No matches");
            #endregion

            #region Where
            // contains = Innehåller
            // Equals = exakt
            // Where loopar igenom Person och lägger till de "John" som finns till arrayen subset.
            // Subset är en del av en större kollektion
            Person[] subset = people
                .Where(person => person.FirstName.Contains("John"))
                .ToArray();

            // Svarskod:
            //
            //foreach (var person in subset)
            //{
            //    Console.WriteLine("Where: {0} ", person.ToString());
            //}
            #endregion

            #region Select
            // Select väljer det som önskas för lagring där det önskas.
            // Kallas för mappning när man lagrar ner alla properties i en array.

            // Man vill gärna mappa data om objektet har mer än två properties.
            // Exempelvis kan man mappa förnamn och efternamn till en property istället för två.
            PersonMeta[] peopleMeta = people
                .Select(person => new PersonMeta { FullName = person.ToString() })
                .ToArray();

            foreach (var meta in peopleMeta)
            {
                Console.WriteLine("Metadata: {0}", meta.FullName);
            }

            string[] firstNames = people
                .Select(person => person.FirstName)
                .ToArray();

            foreach (var firstName in firstNames)
            {
                Console.WriteLine("First Names: {0}", firstName);
            }

            #endregion

            #region Chaining
            // För att göra en stringarray som innehåller Niklas så kan Where och Select kedjas samman.
            // Where -> Select -> Single/First
            string[] allNiklas = people
                .Where(person => String.Equals(person.FirstName, "Niklas"))
                .Select(person => person.FirstName)
                .ToArray();
            foreach (var niklas in allNiklas)
            {
                Console.WriteLine(niklas);
            }
            #endregion

            #region Remove
            // Remove()-metoden i en lista förväntar sig en parameter.
            // Det går att använda LINQ för att hitta det som ska tas bort.
            Person personToRemove = people
                .SingleOrDefault(person => String.Equals(person.ToString(), "John Fristedt"));

            people.Remove(personToRemove);

            foreach (var person in people)
            {
                Console.WriteLine(person.ToString());
            }
            #endregion


        }
    }
}
        #region Motsatsen till en Where
        // Where gör mer eller mindre samma sak som nedan, fast loopar det.
        // Varje gång det blir true så läggs resultatet till i arrayen.
        //public bool MyFunction(Person person)
        //{
        //    if (person.FirstName.Contains("John"))
        //        return true;
        //    return false;
        //}

        //Måste returneras med:
        //bool myFunction = MyFunction(person)
        //    if (myFunction)
        //    Console.WriteLine(myFunction);
        #endregion


