using System;
using System.Collections.Generic;

namespace P03_HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> namesList = new List<string>();
            for (int i = 0; i < numberOfCommands; i++)
            {
                List<string> tokens = new List <string>(Console.ReadLine().Split());

                if (tokens.Count == 4)
                {
                    if (namesList.Contains(tokens[0]) == true)
                    {
                        namesList.Remove(tokens[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{tokens[0]} is not in the list!");
                    }
                }
                else if (tokens.Count == 3)
                {
                    if (namesList.Contains(tokens[0]) == true)
                    {
                        Console.WriteLine($"{tokens[0]} is already in the list!");
                    }
                    else
                    {
                        namesList.Add(tokens[0]);
                    }
                }                
            }
            foreach (var name in namesList)
            {
                Console.WriteLine(name);
            }
        }
    }
}
