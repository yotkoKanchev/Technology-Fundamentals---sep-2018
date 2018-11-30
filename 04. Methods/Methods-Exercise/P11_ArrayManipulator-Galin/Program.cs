using System;
using System.Linq;

namespace P11_Galin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                string[] tokens = line.Split();

                string command = tokens[0];

                if (command == "exchange")
                {
                    int index = int.Parse(tokens[1]);

                    if (index > array.Length-1)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    Exchange(array, index);
                }

                else if (command == "max")
                {
                    string typeNumber = tokens[1];
                    int index = -1;
                    if (typeNumber == "odd")
                    {
                        index = GetMaxEvenOrOddIndex(array, 1);
                    }
                    else
                    {
                        index = GetMaxEvenOrOddIndex(array, 0);
                    }

                    if (index == -1)
                    {
                        Console.WriteLine("No matches");
                        continue;
                    }
                    Console.WriteLine(index);

                }
                else if (command == "min")
                {
                    string typeNumber = tokens[1];
                    int index = -1;

                    if (typeNumber == "odd")
                    {
                        index = GetEvenOrOddIndex(array, 1);
                    }
                    else
                    {
                        index = GetEvenOrOddIndex(array, 0);
                    }
                    if (index == -1)
                    {
                        Console.WriteLine("No matches");
                        continue;
                    }
                    Console.WriteLine(index);
                }
                else if (command == "first")
                {
                    int count = int.Parse(tokens[1]);
                    if (count > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    string typeNumber = tokens[2];

                    int[] resultArray = new int[0];

                    if (typeNumber == "odd")
                    {
                        resultArray = GetFirstCount(array, count, 1);
                    }
                    else
                    {
                        resultArray = GetFirstCount(array, count, 0);
                    }
                    Console.WriteLine($"[{string.Join(", ", resultArray)}]");
                }
                else if (command == "last")
                {
                    int count = int.Parse(tokens[1]);
                    if (count > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    string typeNumber = tokens[2];

                    int []resultArray = new int[0];

                    if (typeNumber == "odd")
                    {
                        resultArray = GetLastCount(array, count, 1);
                    }
                    else
                    {
                        resultArray = GetLastCount(array, count, 0);
                    }
                    Console.WriteLine($"[{string.Join(", ", resultArray)}]");
                }
            }
            Console.WriteLine($"[{string.Join(", ", array)}]");

        }

        private static int[] GetLastCount(int[] array, int count, int evenOrOdd)
        {
            int[] arreyResult = new int[count];

            int counter = 0;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 == evenOrOdd && counter < count)
                {
                    arreyResult[counter] = array[i];
                    counter++;
                }
            }

            if (counter >= count)
            {
                return arreyResult.Reverse().ToArray();
            }
            else
            {
                int[] tempArray = new int[counter];
                Array.Copy(arreyResult, tempArray, counter);

                return tempArray.Reverse().ToArray();
            }
        }

        private static int[] GetFirstCount(int[] array, int count, int evenOrOdd)
        {
            int[] arreyResult = new int[count];

            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == evenOrOdd && counter < count)
                {
                    arreyResult[counter] = array[i];
                    counter++;
                }
            }

            if (counter >= count)
            {
                return arreyResult;
            }
            else
            {
                int[] tempArray = new int[counter];
                Array.Copy(arreyResult, tempArray, counter);

                return tempArray;
            }
        }

        private static int GetEvenOrOddIndex(int[] array, int divisioneResult)
        {
            int minNumber = int.MaxValue;
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= minNumber && array[i] % 2 == divisioneResult)
                {
                    minNumber = array[i];
                    index = i;
                }
            }
            return index;
        }

        private static int GetMaxEvenOrOddIndex(int[] array, int divisioneResult)
        {
            int maxNumber = int.MinValue;
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {        
                if (array[i] > maxNumber && array[i]% 2 == divisioneResult)
                {
                    maxNumber = array[i];
                    index = i;
                }
            }
            return index;
        }

        private static void Exchange(int[] array, int index)
        {
            for (int i = 0; i < index+1; i++)
            {
                int firstNumber = array[0];

                for (int j = 0; j < array.Length-1; j++)
                {
                    array[j] = array[j + 1];
                }

                array[array.Length - 1] = firstNumber;
            }
        }
    }
}
