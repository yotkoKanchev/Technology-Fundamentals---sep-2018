using System;
using System.Linq;

namespace _09._1_Galin
{
    class Program
    {
        static void Main(string[] args)
        {
            int DNALenght = int.Parse(Console.ReadLine());

            int length = 0;
            int startIndex = -1;
            int row = 0;
            int currentRow = 1;
            int sum = 0;

            int[] DNA = new int[DNALenght];

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Clone them!")
                {
                    break;
                }

                int[] currentDNA = line
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int currentSum = 0;

                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if (currentDNA[i] == 1)
                    {
                        currentSum++;
                    }
                }

                if (currentSum == 1)
                {
                    DNA = currentDNA;
                    row = currentRow;
                    sum = currentSum;
                }
                int currentStartIndex = -1;
                int currentLength = 0;
                bool isFound = false;

                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if (currentDNA[i] == 1)
                    {
                        if (!isFound)
                        {
                            currentStartIndex = i;
                        }
                    }

                    currentLength++;

                    if (currentLength>length)
                    {
                        length = currentLength;
                        startIndex = currentStartIndex;
                        sum = currentSum;
                        row = currentRow;

                        DNA = currentDNA;
                    }
                    else if (currentLength == length)
                    {
                        if (currentStartIndex < startIndex)
                        {
                            length = currentLength;
                            startIndex = currentStartIndex;
                            sum = currentSum;
                            row = currentRow;

                            DNA = currentDNA;
                        }
                        else if (currentSum > sum)
                        {
                            length = currentLength;
                            startIndex = currentStartIndex;
                            sum = currentSum;
                            row = currentRow;

                            DNA = currentDNA;
                        }
                    }

                }
                currentLength++;
            }
        }
    }
}
