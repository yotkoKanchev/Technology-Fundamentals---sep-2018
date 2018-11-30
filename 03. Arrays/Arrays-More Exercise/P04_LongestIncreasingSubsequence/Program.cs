using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var resultList = new List<int>();
            var currentList = new List<int>();

            int bestStartIndex = 0;
            int startIndex = 0;
            int bestLegth = 0;
            int lenght = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                currentList.Add(numbers[i]);
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[j] > currentList[currentList.Count - 1])
                    {
                        currentList.Add(numbers[j]);
                        lenght = currentList.Count;
                        startIndex = i;
                    }
                    else if (numbers[j] < currentList[currentList.Count - 1] )
                    {
                        if (currentList.Count>=2)
                        {
                            if (numbers[j] > currentList[currentList.Count - 2])
                            {
                                currentList.RemoveAt(currentList.Count - 1);
                                currentList.Add(numbers[j]);
                                lenght = currentList.Count;
                                startIndex = i;
                            }
                        }
                    }
                }
                if (lenght > bestLegth)
                {
                    resultList = new List<int>();
                    for (int k = 0; k < currentList.Count; k++)
                    {
                        resultList.Add(currentList[k]);
                        bestLegth = lenght;
                        bestStartIndex = startIndex;
                    }
                }
                else if (lenght == bestLegth)
                {
                    if (startIndex<bestStartIndex)
                    {
                        resultList = new List<int>();
                        for (int k = 0; k < currentList.Count; k++)
                        {
                            resultList.Add(currentList[k]);
                            bestLegth = lenght;
                            bestStartIndex = startIndex;
                        }
                    }
                }
                currentList = new List<int>();
            }            
            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
