using System;
using System.Linq;

namespace P03_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            int[] bestBread = new int[0];
            int bestTotalQuality = int.MinValue;
            double bestAverageQuality = double.MinValue;
            int bestLength = int.MaxValue;


            while (inputLine != "Bake It!")
            {
                int[] tokens = inputLine
                    .Split("#",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int[] currentBread = tokens;
                int currentTotalQuality = currentBread.Sum();
                double currentAverageQuality = currentBread.Average();
                int currentLength = currentBread.Length;

                if (currentTotalQuality > bestTotalQuality)
                {
                    bestBread = currentBread;
                    bestTotalQuality = currentTotalQuality;
                    bestAverageQuality = currentAverageQuality;
                    bestLength = currentLength;                                       
                }
                else if (currentTotalQuality == bestTotalQuality)
                {
                    if (bestAverageQuality < currentAverageQuality)
                    {
                        bestBread = currentBread;
                        bestTotalQuality = currentTotalQuality;
                        bestAverageQuality = currentAverageQuality;
                        bestLength = currentLength;
                    }
                    else if (bestAverageQuality == currentAverageQuality)
                    {
                        if (bestLength > currentLength)
                        {
                            bestBread = currentBread;
                            bestTotalQuality = currentTotalQuality;
                            bestAverageQuality = currentAverageQuality;
                            bestLength = currentLength;
                        }
                    }
                }   

                inputLine = Console.ReadLine();
            }
            Console.WriteLine($"Best Batch quality: {bestTotalQuality}");
            Console.WriteLine(string.Join(" ", bestBread));
        }
    }
}
