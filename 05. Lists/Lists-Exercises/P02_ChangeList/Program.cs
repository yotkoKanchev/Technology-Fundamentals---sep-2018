using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_ChangeList
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
                int element = int.Parse(tokens[1]);
                switch (command)
                {
                    case "Delete":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] == element)
                            {
                                numbers.RemoveAt(i);
                                i--;
                            }
                        }
                        break;
                    case "Insert":
                        int position = int.Parse(tokens[2]);
                        numbers.Insert(position, element);
                        break;
                    default:
                        break;
                }

                inputLine = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
