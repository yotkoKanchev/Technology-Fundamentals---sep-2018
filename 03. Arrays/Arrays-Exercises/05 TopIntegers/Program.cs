using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            bool isTopInteger = true;

            List<int> resultList = new List<int>();
            for (int i = 0; i < numbers.Count-1; i++)
            {
                for (int j = i+1; j < numbers.Count; j++)
                {
                    if (numbers[i] <= numbers[j])
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger == true)
                {
                    resultList.Add(numbers[i]);
                }
                isTopInteger = true;
            }
            resultList.Add(numbers[numbers.Count - 1]);
            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
