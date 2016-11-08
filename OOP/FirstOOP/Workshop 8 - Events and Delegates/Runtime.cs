using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_8___Events_and_Delegates
{
    class Runtime
    {
        public delegate void MyDelegate(string message); // delegates är som en variabel som innehåller en metod.
                // Delegaten och Delegatmetoden måste ha samma typ av returvärde.

        public void DelegateMethod(string message) // Definerar metoden som delegaten MyDelegate ska innehålla
        {
            Console.WriteLine(message);
        }

        public void Start()
        {
            #region Delegates
            Console.WriteLine("---");
            Console.WriteLine("Delegates");
            Console.WriteLine("---");
            // Delegates måste instansieras och det finns fyra sätt att göra det på.

            // Delegates in C# 1.0
            MyDelegate del1 = new MyDelegate(DelegateMethod);

            // C# 2.0 - Recommended ***
            MyDelegate del2 = DelegateMethod;

            // C# 2.0 anonymous method
            MyDelegate del3 = delegate (string message)
            {
                Console.WriteLine(message);
            };

            // C# 3.0 - Recommended (using Lambda) ***
            MyDelegate del4 = (message) =>
            {
                Console.WriteLine(message);
            };

            del1("Hello world!");

            MyClass myObject = new MyClass();

            // Sends del4 to MyClass.Test which then prints the message.
            myObject.Test(del4);

            #endregion

            #region Actions & Funcs
            Console.WriteLine("---");
            Console.WriteLine("Actions & funcs");
            Console.WriteLine("---");
            // Action is _like_ a delegate. There's a difference in how it is defined.
            // It may have any number of input parameters, but no return type.
            Action<string> myAction = (message) =>
            {
                Console.WriteLine(message);
            };

            myObject.ActionTest(myAction);

            // Func may also take any number of inputs but must always have a return type.
            // The last type in the Func declaration decides the return type.
            Func<int, int, int> myFunc = (n1, n2) =>
            {
                return n1 + n2;
            };

            myObject.Calculator(myFunc);

            Func<int, int, int> myFunc2 = (n1, n2) =>
            {
                return n1 * n2;
            };

            myObject.Calculator(myFunc2);

            #endregion

            #region Find and where

            Console.WriteLine("---");
            Console.WriteLine("Find and where");
            Console.WriteLine("---");
            string result = myObject.Find(word => string.Equals(word, "String 5"));

            if (result != null)
                Console.WriteLine(result);
            else
                Console.WriteLine("Null");

            string[] whereResult = myObject.Where(word => !word.Contains("String") || !word.Contains("Bar"));

            foreach (var word in whereResult)
            {
                Console.WriteLine(word);
            }

            #endregion

            #region Counter
            Console.Clear();
            Console.WriteLine("---");
            Console.WriteLine("Counter");
            Console.WriteLine("---");

            var loop = true;
            var counter = new Counter { Threshold = 3 };

            counter.ThresholdReached += (sender, e) =>
            {
                Console.WriteLine("Threshold reached, aborting");
                loop = false;
            };

            counter.ThresholdReached += (sender, e) =>
            {
                Console.WriteLine("Second event method");
            };

            while (loop)
            {
                Console.WriteLine("Total: {0}", counter.Total);
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.UpArrow:
                        counter.Add(1);
                        break;
                    case ConsoleKey.DownArrow:
                        counter.Add(-1);
                        break;
                }
            }

            #endregion
        }

        private void Counter_ThresholdReached(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
