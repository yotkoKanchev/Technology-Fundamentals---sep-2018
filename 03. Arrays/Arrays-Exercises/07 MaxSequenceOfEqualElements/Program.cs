using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();

            List<string> resultList = new List<string>();
            List<string> tempList = new List<string>();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                tempList = new List<string>();
                tempList.Add(numbers[i]);
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        tempList.Add(numbers[j]);
                        if (tempList.Count > resultList.Count)
                        {
                            resultList = tempList.ToList();
                        }
                    }
                    else
                    {
                        break;
                    }
                }                
            }
            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
