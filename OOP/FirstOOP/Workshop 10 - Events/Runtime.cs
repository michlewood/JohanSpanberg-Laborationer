using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_10___Events
{
    public delegate void PrintMessage();

    class Runtime
    {
        // Declares an event by using the 'event'-keyword followed by the
        // event handler delegate type. The name of an event should describe
        // the condition for raising the event.

        private event PrintMessage ApplicationStarted;

        internal void Start()
        {
            ApplicationStarted += new PrintMessage(Message1);

            OnApplicationStarted();

            Console.WriteLine("Korvlåda");

            ApplicationStarted += new PrintMessage(Message2);
            OnApplicationStarted();


        }

        private void OnApplicationStarted()
        {
            ApplicationStarted?.Invoke();
        }

        public void Message1()
        {
            Console.WriteLine("Welcome to this super cool application");
        }

        public void Message2()
        {
            Console.WriteLine("Everything is fine, all systems nominal");
        }
    }
}
