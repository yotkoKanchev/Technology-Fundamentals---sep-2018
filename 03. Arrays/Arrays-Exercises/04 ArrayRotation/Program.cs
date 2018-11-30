using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();

            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations % numbers.Count; i++)
            {
                numbers.Add(numbers[0]);
                numbers.RemoveAt(0);
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
