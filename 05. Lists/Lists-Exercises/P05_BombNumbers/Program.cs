using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToList();

            int[] arguments = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int specialNumber = arguments[0];
            int power = arguments[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == specialNumber)
                {

                    int startPoint = 0;
                    int endPoint = 0;

                    if (i - power < 0)
                    {
                        startPoint = 0;
                    }
                    else
                    {
                        startPoint = i - power;
                    }

                    if (i + power > numbers.Count - 1)
                    {
                        endPoint = numbers.Count - 1;
                    }
                    else
                    {
                        endPoint = i + power;
                    }
                    for (int j = endPoint; j >= i + 1; j--)
                    {
                        numbers.RemoveAt(j);
                    }
                    numbers.RemoveAt(i);

                    for (int k = i - 1; k >= startPoint; k--)
                    {
                        numbers.RemoveAt(k);
                    }
                    i = -1;
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
