using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_8___Delegater
{
    class Runtime
    {
        public delegate string StringConcatinator(string[] stringCollection);
        public delegate float NumberOperator(float[] floatCollection, bool multiplicate);
        

        public string[] stringCollection = { "korv", "Nils", "Peter", "Stefan" };
        public float[] floatCollection = { 4.1F, 5.5F, 7.1F};

        public string StringConcatinatorMethod(string[] stringCollection)
        {
            string result = "";
            for (int i = 0; i < stringCollection.Length; i++)
            {
                result = result + stringCollection[i] + ", ";
            }
            return result;
        }

        public float NumberOperatorMethod(float[] floatCollection, bool multiplicate)
        {
            float numberResult = 0;

            if (multiplicate)
            {
                numberResult = floatCollection[0];
                for (int i = 1; i < floatCollection.Length; i++)
                {
                    numberResult = numberResult * floatCollection[i];
                }
            }
            else
            {
                for (int i = 0; i < floatCollection.Length; i++)
                {
                    numberResult = numberResult + floatCollection[i];
                }
            }

            return numberResult;
        }

        internal void Start()
        {
            StringConcatinator stringConcatinator = StringConcatinatorMethod;
            NumberOperator numberOperator = NumberOperatorMethod;

            Console.WriteLine(stringConcatinator(stringCollection));

            bool selector = true;

            Console.WriteLine(numberOperator(floatCollection, selector));


        }
    }
}
