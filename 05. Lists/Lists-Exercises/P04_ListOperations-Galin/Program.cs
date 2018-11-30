using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Galin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string[] tokens = input.Split();
                string command = tokens[0];
                if (command == "Add")
                {
                    int numberToAdd = int.Parse(tokens[1]);
                    numbers.Add(numberToAdd);
                }

                else if (command == "Insert")
                {
                    int numberToInsert = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    if (index > numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.Insert(index, numberToInsert);
                }
                else if (command == "Remove")
                {
                    int index = int.Parse(tokens[1]);
                    if (index > numbers.Count|| index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(index);
                }
                else if (command == "Shift")
                {
                    string direction = tokens[1];
                    int rotations = int.Parse(tokens[2]);

                    if (direction == "left")
                    {
                        for (int i = 0; i < rotations % numbers.Count; i++)
                        {
                            int firstNumber = numbers[0];

                            for (int j = 0; j < numbers.Count-1; j++)
                            {
                                numbers[j] = numbers[j + 1];
                            }

                            numbers[numbers.Count - 1] = firstNumber;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < rotations % numbers.Count; i++)
                        {
                            int lastNumber = numbers[numbers.Count-1];

                            for (int j = numbers.Count-1; j > 0; j--)
                            {
                                numbers[j] = numbers[j - 1];
                            }

                            numbers[0] = lastNumber;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
