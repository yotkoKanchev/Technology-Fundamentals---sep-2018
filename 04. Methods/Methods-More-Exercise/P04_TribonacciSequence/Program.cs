using System;
using System.Linq;
using System.Collections.Generic;

namespace P04_TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            var listNumers = new List<int>();
            listNumers.Add(1);

            for (int i = 0; i < num-1; i++)
            {
                if (i < 3)
                {
                    listNumers.Add(listNumers.Sum());
                }
                else
                {
                    listNumers.Add(listNumers[i] + listNumers[i - 1] + listNumers[i - 2]);
                }
            }

            Console.WriteLine(string.Join(" ", listNumers));
        }
    }
}
