using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Workshop_8___Events_and_Delegates.Runtime;

namespace Workshop_8___Events_and_Delegates
{
    class MyClass
    {
        public string[] MyArray { get; set; }

        public MyClass()
        {
            MyArray = new string[]
            {
                "String 1",
                "String 2",
                "String 3",
                "String 4",
                "String 5",
                "Hello",
                "From",
                "The",
                "Classroom",
                "We",
                "Say",
                "Bar",
            };
        }

        public void Test(MyDelegate callback)
        {
            callback("Hello from MyClass");
        }

        public void ActionTest(Action<string> actionCallback)
        {
            actionCallback("Action in MyClass");
        }

        public void Calculator(Func<int, int, int> calcFunc)
        {
            int result = calcFunc(5, 5);
            Console.WriteLine(result);
        }

        public string Find(Func<string, bool> findFunc)
        {
            foreach (var word in MyArray)
            {
                if (findFunc(word))
                    return word;
            }
            return null;
        }

        public string[] Where(Func<string, bool> whereFunc)
        {
            List<string> result = new List<string>();

            foreach (var word in MyArray)
            {
                if (whereFunc(word))
                    result.Add(word);
            }

            return result.ToArray();
        }

    }
}
