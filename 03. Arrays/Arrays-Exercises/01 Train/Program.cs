using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());
            List<int> train = new List<int>();

            for (int i = 0; i < numberOfWagons; i++)
            {
                train.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine(string.Join(" ",train));
            Console.WriteLine(train.Sum());
        }
    }
}
