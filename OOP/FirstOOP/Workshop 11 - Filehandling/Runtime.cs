using Newtonsoft.Json;
using System;
using System.IO;
using Workshop_11___Filehandling.Models;

namespace Workshop_11___Filehandling
{
    internal class Runtime
    {
        internal void Start()
        {
            var directory = Environment.CurrentDirectory;
            var file = String.Format("{0}{1}", directory, "\\data.json");

            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            if (!File.Exists(file))
                File.Create(file);

            //Person myPerson = new Person { Id = 1, Name = "Steve", Age = 32 };

            //string jsonString = JsonConvert.SerializeObject(myPerson);

            //File.WriteAllText(file, jsonString);

            //Person[] myArray = new Person[]
            //{
            //    new Models.Person {Id=1, Name = "Steve", Age = 32 },
            //    new Models.Person {Id=2, Name = "Alice", Age = 57 },
            //    new Models.Person {Id=3, Name = "Anna", Age = 21 },
            //};

            //// Serializes the object/array, meaning the object is converted
            //// to a formatted text string.
            //string jsonString = JsonConvert.SerializeObject(myArray);

            //// Writes the JSON-formatted text to a file.
            //File.WriteAllText(file, jsonString);

            string jsonFromFile = File.ReadAllText(file);

            Person[] mySerializedArray = JsonConvert.DeserializeObject<Person[]>(jsonFromFile);

            foreach (var person in mySerializedArray)
            {
                Console.WriteLine("{0}, {1}, {2}", person.Id, person.Name, person.Age);
            }
            Console.ReadLine();
        }
    }
}