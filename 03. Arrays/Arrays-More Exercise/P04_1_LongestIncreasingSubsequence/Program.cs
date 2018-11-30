using System;
using System.Linq;

namespace P04._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] temArray = new int[myArray.Length];
            int[] resultArray = new int[myArray.Length];

            int maxLength = 0;
            int lastIndex = -1;

            for (int i = 0; i < myArray.Length; i++)
            {
                temArray[i] = 1;
                resultArray[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (myArray[j] < myArray[i] && temArray[j] + 1 > temArray[i])
                    {
                        temArray[i] = temArray[j] + 1;
                        resultArray[i] = j;
                    }
                }                    
                if (temArray[i] > maxLength)
                {
                    maxLength = temArray[i];
                    lastIndex = i;
                }
            }
            int counter = 0;
            int[] finalArray = new int[maxLength];
            while (lastIndex != -1)
            {
                finalArray[counter] = myArray[lastIndex];
                counter++;
                lastIndex = resultArray[lastIndex];
            }

            Array.Sort(finalArray);

            Console.WriteLine(string.Join(" ",finalArray));
        }

    }
}
