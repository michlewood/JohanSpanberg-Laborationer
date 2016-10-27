using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_6___Interfaces.Classes;
using Workshop_6___Interfaces.Interfaces;

namespace Workshop_6___Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Old stuff
            //IFlyable bird = new Bird();
            //IFlyable plane = new Plane();

            //bird.Fly();
            //plane.Fly();
            #endregion

            // Skriv en objektvariabel till ett interface betyder att vi kan behandla alla
            // klasser eller objekt som använder detta interface på samma sätt.
            // Exempelvis kan vi lägga till olika klasser till en lista med interfaces.
            // Nackdelen är att vi inte kan komma åt objektens properties eller metoder som är
            // specifika för Bird eller Plane utan att typecasta.
            List<IFlyable> flyingThings = new List<IFlyable>
            {
                new Bird { color = "Red", TopSpeed = 50 },
                new Plane {TopSpeed = 10000 }
            };

            
            Console.WriteLine("Flying things.");
            foreach (var flyingThing in flyingThings)
            {
                #region Kraschar när vi kommer till Plane eftersom att vi inte kan typecasta Plane till bird
                //Console.WriteLine(((Bird)flyingThing).color);
                #endregion

                flyingThing.Fly();
                Console.WriteLine(" at the speed of {0} km/h.", flyingThing.TopSpeed); 
            }


            List<ISpeakable> speakingThings = new List<ISpeakable>
            {
                new Bird {color = "Green", TopSpeed = 40 },
                new Person(),
                new Dog()
            };

            Console.WriteLine();
            Console.WriteLine("Speaking things:");
            foreach (var speakingThing in speakingThings)
            {
                Console.WriteLine(speakingThing.Speak());
            }
        }
    }
}
