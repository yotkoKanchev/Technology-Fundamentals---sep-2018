using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_BakingFactory
{
    class Program
    {
        private static object bestBreadBatch;

        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();


            int bestQuality = int.MinValue;
            double bestAverageQuality = double.MinValue;
            int lowestNumberOfBatches = int.MaxValue;
            int[] bestBreadBatch = new int[0];

            while (inputLine != "Bake It!")
            {
                int[] breadBatches = inputLine
                    .Split("#", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (breadBatches.Sum() > bestQuality)
                {
                    bestQuality = breadBatches.Sum();
                    bestAverageQuality = breadBatches.Average();
                    lowestNumberOfBatches = breadBatches.Length;
                    bestBreadBatch = breadBatches;
                }
                else if (breadBatches.Sum() == bestQuality)
                {
                    if (breadBatches.Average() > bestAverageQuality)
                    {
                        bestQuality = breadBatches.Sum();
                        bestAverageQuality = breadBatches.Average();
                        lowestNumberOfBatches = breadBatches.Length;
                        bestBreadBatch = breadBatches;
                    }
                    else if (breadBatches.Average() == bestAverageQuality)
                    {
                        if (breadBatches.Length < lowestNumberOfBatches)
                        {
                            bestQuality = breadBatches.Sum();
                            bestAverageQuality = breadBatches.Average();
                            lowestNumberOfBatches = breadBatches.Length;
                            bestBreadBatch = breadBatches;
                        }
                    }
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine($"Best Batch quality: {bestQuality}");
            Console.WriteLine(string.Join(" ", bestBreadBatch));
        }
    }
}