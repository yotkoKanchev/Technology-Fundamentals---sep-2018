using System;
using System.Collections.Generic;

namespace _02._11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();

            List<string> resultList = new List<string>();

            for (int i = 0; i < secondArray.Length; i++)
            {
                for (int j = 0; j < firstArray.Length; j++)
                {
                    if (secondArray[i] == firstArray[j])
                    {
                        resultList.Add(firstArray[j]);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
