using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split("|").ToArray();
            Array.Reverse(numbers);

            List<int> resultNumbers = new List<int>();

            foreach (var element in numbers)
            {
                for (int i = 0; i < element.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).Length; i++)
                {
                    resultNumbers.Add(int.Parse(element.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[i]));
                }
            }
            Console.WriteLine(string.Join(" ", resultNumbers));
                
        }
    }
}
