using System;
using System.Linq;

namespace _09._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthOfDNA = int.Parse(Console.ReadLine());

            int DNABestLenght = 0;
            int DNABestIndex = -1;
            int DNABestSum = 0;
            int DNAnumber = 1;
            int[] bestDNA = new int[lengthOfDNA]; 

            int number = 0;
            string inputLine = Console.ReadLine();

            while (inputLine != "Clone them!")
            {
                int[] currentDNA = inputLine
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                number++;
                int currentSum = currentDNA.Sum();
                int currentBestLeght = 0;
                int currentLenght = 0;
                int currentBestIndex = 0;
                int currenDNANumber = 0;

                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if (currentDNA[i] == 1)
                    {
                        currentLenght++;
                        if (currentLenght > currentBestLeght)
                        {
                            currentBestLeght = currentLenght;
                            currentBestIndex = i - currentBestLeght + 1;
                            currenDNANumber = number;
                        }                        
                    }
                    else
                    {
                        currentLenght = 0;
                    }
                }

                if (currentBestLeght > DNABestLenght)
                {
                    bestDNA = currentDNA;
                    DNABestIndex = currentBestIndex;
                    DNABestSum = currentSum;
                    DNAnumber = currenDNANumber;
                    DNABestLenght = currentBestLeght;
                }
                else if (currentBestLeght == DNABestLenght)
                {
                    if (currentBestIndex < DNABestIndex)
                    {
                        bestDNA = currentDNA;
                        DNABestIndex = currentBestIndex;
                        DNABestSum = currentSum;
                        DNAnumber = currenDNANumber;
                        DNABestLenght = currentBestLeght;
                    }
                    else if (currentBestIndex == DNABestIndex)
                    {
                        if (currentSum > DNABestSum)
                        {
                            bestDNA = currentDNA;
                            DNABestIndex = currentBestIndex;
                            DNABestSum = currentSum;
                            DNAnumber = currenDNANumber;
                            DNABestLenght = currentBestLeght;
                        }
                    }
                }

                inputLine = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {DNAnumber} with sum: {DNABestSum}.");
            Console.WriteLine(string.Join(" ",bestDNA));
        }
    }
}
