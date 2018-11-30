using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_MixedUpList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int shorterListLength = 0;
            int num1 = 0;
            int num2 = 0;
            if (firstList.Count > secondList.Count)
            {
                num1 = firstList[firstList.Count - 2];
                num2 = firstList[firstList.Count - 1];
                shorterListLength = secondList.Count;
            }
            else
            {
                num1 = secondList[0];
                num2 = secondList[1];
                shorterListLength = firstList.Count;
                secondList.RemoveRange(0, 2);
            }
            if (num1 < 0 && num2 < 0)
            {
                return;
            }
            else if (num1<0 && num2 > 0)
            {
                num1 = 0;
            }
            else if (num2 < 0 && num1 >0 )
            {
                num2 = 0;
            }
            int startNumber = Math.Min(num1, num2);
            int endNumber = Math.Max(num1, num2);
            List<int> resultList = new List<int>();
            for (int i = 0; i < shorterListLength; i++)
            {
                resultList.Add(firstList[i]);
                resultList.Add(secondList[i]);
            }

            resultList.Sort();
            for (int i = 0; i < resultList.Count ; i++)
            {
                if (resultList[i] > startNumber && resultList[i] < endNumber)
                {
                    Console.Write(resultList[i] + " ");
                }
            }
        }
    }
}
