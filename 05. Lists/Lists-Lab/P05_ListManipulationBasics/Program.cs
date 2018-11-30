using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] tokens = inputLine.Split();

                string command = tokens[0];
                int number = int.Parse(tokens[1]);

                switch (command)
                {
                    case "Add":
                        numbers.Add(number);
                        break;
                    case "Remove":
                        numbers.Remove(number);
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(number);
                        break;
                    case "Insert":
                        int index = int.Parse(tokens[2]);
                        numbers.Insert(index,number);
                        break;
                    default:
                        break;
                }

                inputLine = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
