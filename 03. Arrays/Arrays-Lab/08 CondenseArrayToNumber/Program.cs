using System;
using System.Collections.Generic;
using System.Linq;

namespace P08._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
                        
            while (numbers.Count>1)
            {
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    numbers.Insert(i + 1, numbers[i] + numbers[i + 1]);
                    numbers.RemoveAt(i);
                }
                numbers.RemoveAt(numbers.Count - 1);
            }
            Console.WriteLine(numbers[0]);
        }
    }
}
