using System;
using System.Collections.Generic;

namespace P04_ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var listOfStrings = new List<string>();
           
            for (int i = 0; i < n; i++)
            {
                string lineInput = Console.ReadLine();
                listOfStrings.Add(lineInput);
            }
            listOfStrings.Sort();

            for (int i = 0; i < listOfStrings.Count; i++)
            {
                Console.WriteLine($"{i+1}.{listOfStrings[i]}");
            }
        }
    }
}
