using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> trainWagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] tokens = inputLine.Split();
                string command = tokens[0];

                switch (command)
                {
                    case "Add":
                        int wagonToAdd = int.Parse(tokens[1]);
                        trainWagons.Add(wagonToAdd);
                        break;
                    default:
                        int passengersToAdd = int.Parse(command);

                        for (int i = 0; i < trainWagons.Count; i++)

                            if (trainWagons[i] + passengersToAdd <= maxCapacity)
                            {
                                trainWagons[i] += passengersToAdd;
                                break;
                            }

                        break;
                }
                inputLine = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", trainWagons));
        }
    }
}
