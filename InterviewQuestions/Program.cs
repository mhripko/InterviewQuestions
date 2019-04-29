using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    class Program
    {
        static void Main(string[] args)

        {
            InterviewQuestions();
        }

        /// <summary>
        /// InterviewQuestions are some of the commonly asked questions when people are interviewed.
        /// </summary>
        private static void InterviewQuestions()
        {
            int[] inputArray = { 1, 2, 3, 4, 4, 5, 6, 6, 6, 7, 8, 9, 10, 10 };
            FindAllDuplicateIntegers(inputArray);
            Console.ReadKey();

            int[] elem = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] test = { 1, 2, 3, 4, 5, 7, 8, 9, 10 };
            MissingNumber(elem, test);
            Console.ReadKey();

            int a = 10;
            int b = 7;
            Swap2Numbers(a, b);
            Console.ReadKey();
        }

        /// <summary>
        /// FindAllDuplicateIntegers will output any duplicates from a set of integers passed in.
        /// </summary>
        /// <param name="inputArray">An array of integers with duplicates allowed</param>
        private static void FindAllDuplicateIntegers(int[] inputArray)
        {
            // Find all duplicates...
            
            int length = inputArray.Length;
            HashSet<int> outputHash = new HashSet<int>();
            HashSet<int> tempHash = new HashSet<int>();


            for (int i = 0; i < length; i++)
            {
                if (tempHash.Contains(inputArray[i]))
                {
                    outputHash.Add(inputArray[i]);
                }
                else
                {
                    tempHash.Add(inputArray[i]);
                }
            }

            Console.Write("{");
            foreach (int i in outputHash)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine(" }");
        }

        /// <summary>
        /// Swap2Numbers will swap two integers without having to allocate or use more then 2 native variables.
        /// </summary>
        /// <param name="a">An integer for the first value</param>
        /// <param name="b">An integer for the 2nd value</param>
        private static void Swap2Numbers(int a, int b)
        {
            a = a + b;
            Console.WriteLine("Adding a+b: {0}", a);
            b = a - b;
            Console.WriteLine("b = a-b: {0}", b);
            a = a - b;
            Console.WriteLine("a = a-b: {0}", a);
        }

        /// <summary>
        /// MissingNumber will take an ordered array of integers and find whatever integer values are missing
        /// </summary>
        /// <param name="elem">An array of integers from lowest to highest</param>
        /// <param name="test">An array of integers with any missing value</param>
        private static void MissingNumber(int[] elem, int[] test)
        {
            
            int length = elem.Count();
            int number = 0;
            for (int i = 0; i < length + 1; i++)
            {
                number = number + i;

            }
            Console.WriteLine("sum of all numbers = {0} ", number);

            int testnumber = 0;
            int lengthtest = test.Count();
            for (int i = 0; i < lengthtest; i++)
            {
                testnumber = testnumber + test[i];

            }

            Console.WriteLine("missing numbers = {0} ", number - testnumber);

        }
    }
}
