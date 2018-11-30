using System;
using System.Linq;

namespace P06._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            int[] evenNumsArray = inputLine
                .Split()
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .ToArray();

            int[] oddNumsArray = inputLine
                .Split()
                .Select(int.Parse)
                .Where(x => x % 2 != 0)
                .ToArray();

            Console.WriteLine(evenNumsArray.Sum() - oddNumsArray.Sum());
        }
    }
}
