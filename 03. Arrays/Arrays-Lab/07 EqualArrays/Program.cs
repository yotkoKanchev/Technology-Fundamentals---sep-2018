using System;
using System.Linq;

namespace P07._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] secondArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            bool areEqual = true;
            int differIndex = 0;
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    areEqual = false;
                    differIndex = i;
                    break;
                }
            }

            if (areEqual)
            {
                Console.WriteLine($"Arrays are identical. Sum: {firstArray.Sum()}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {differIndex} index");
            }
        }
    }
}
