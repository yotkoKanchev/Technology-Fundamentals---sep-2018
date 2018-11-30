using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int index = -1;

            for (int i = 0; i < numbers.Count; i++)
            {
                int leftSum = numbers.Take(i).Sum();
                int rightSum = numbers.Skip(i+1).Take(numbers.Count - i).Sum();
                if (leftSum == rightSum)
                {
                    index = i;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
    }
}
