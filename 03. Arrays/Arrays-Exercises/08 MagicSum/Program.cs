using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int sumNumber = int.Parse(Console.ReadLine());

            for (int i = 0;  i < numbers.Count-1; i++)
            {
                for (int j = i+1; j < numbers.Count; j++)
                {
                    if (numbers[i] + numbers[j] == sumNumber)
                    {
                        Console.WriteLine($"{numbers[i]} {numbers[j]}");
                    }
                }
            }
        }
    }
}
