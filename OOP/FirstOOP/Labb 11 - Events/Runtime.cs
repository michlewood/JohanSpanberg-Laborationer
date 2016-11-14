using Labb_11___Events.Filters;
using System;
using System.Collections;

namespace Labb_11___Events
{
    public delegate void PrintMessage();

    internal class Runtime
    {
        private event AnalyzeNumber NumberInput;

        internal void Start()
        {

            NumberInput += NumberFilters.IsEven;
            NumberInput += NumberFilters.IsDividableByThree;
            NumberInput += NumberFilters.IsPrimeNumber;

            while (true)
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                NumberInput(number);
                
                Console.ReadLine();
  
            }
        }
    }
}