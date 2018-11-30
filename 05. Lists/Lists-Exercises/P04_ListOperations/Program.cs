using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_ListOperations
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

            while (inputLine != "End")
            {
                string[] tokens = inputLine.Split();
                string command = tokens[0];

                switch (command)
                {
                    case "Add":
                        int number = int.Parse(tokens[1]);
                        numbers.Add(number);
                        break;

                    case "Insert":
                        number = int.Parse(tokens[1]);
                        int index = int.Parse(tokens[2]);
                        if (index > numbers.Count - 1 || index < 0)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        numbers.Insert(index, number);
                        break;

                    case "Remove":
                        index = int.Parse(tokens[1]);
                        if (index > numbers.Count-1 || index < 0)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        numbers.RemoveAt(index);
                        break;

                    case "Shift":
                        string direction = tokens[1];
                        int count = int.Parse(tokens[2]);

                        if (direction == "left")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                numbers.Add(numbers[0]);
                                numbers.RemoveAt(0);
                            }
                        }
                        else if (direction == "right")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                numbers.Insert(0,numbers[numbers.Count-1]);
                                numbers.RemoveAt(numbers.Count-1);
                            }
                        }
                        break;                 
                }

                inputLine = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
