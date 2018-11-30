using System;
using System.Linq;

namespace P05._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .ToArray();

            Console.WriteLine(numbers.Sum());
        }
    }
}
