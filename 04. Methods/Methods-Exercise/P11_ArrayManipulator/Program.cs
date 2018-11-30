using System;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string inpute = Console.ReadLine();

            while (inpute != "end")
            {
                string[] arguments = inpute.Split();
                string command = arguments[0];

                switch (command)
                {
                    case "exchange":
                        int index = int.Parse(arguments[1]);

                        if (index > arrayNumbers.Length - 1 || index < 0)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        ExchangeNumbers(arrayNumbers, index);
                        break;

                    case "max":
                        string numberType = arguments[1];
                        index = -1;

                        if (numberType == "odd")
                        {
                            index = GetMaxIndex(arrayNumbers, 1);
                        }
                        else
                        {
                            index = GetMaxIndex(arrayNumbers, 0);
                        }
                        if (index == -1)
                        {
                            Console.WriteLine("No matches");
                            break;
                        }
                        Console.WriteLine(index);

                        break;
                    case "min":
                        numberType = arguments[1];
                        index = -1;

                        if (numberType == "odd")
                        {
                            index = GetMinIndex(arrayNumbers, 1);
                        }
                        else
                        {
                            index = GetMinIndex(arrayNumbers, 0);
                        }
                        if (index == -1)
                        {
                            Console.WriteLine("No matches");
                            break ;
                        }
                        Console.WriteLine(index);
                        break;
                    case "first":
                        int count = int.Parse(arguments[1]);
                        if (count > arrayNumbers.Length)
                        {
                            Console.WriteLine("Invalid count");
                            break;
                        }
                        numberType = arguments[2];

                        int[] resultArray = new int[0];

                        if (numberType == "odd")
                        {
                            resultArray = GetFirstCount(arrayNumbers, count, 1);
                        }
                        else
                        {
                            resultArray = GetFirstCount(arrayNumbers, count, 0);
                        }
                        Console.WriteLine($"[{string.Join(", ", resultArray)}]");
                        break;
                    case "last":
                        count = int.Parse(arguments[1]);
                        if (count > arrayNumbers.Length)
                        {
                            Console.WriteLine("Invalid count");
                            break;
                        }
                        numberType = arguments[2];

                        resultArray = new int[0];

                        if (numberType == "odd")
                        {
                            resultArray = GetLastCount(arrayNumbers, count, 1);
                        }
                        else
                        {
                            resultArray = GetLastCount(arrayNumbers, count, 0);
                        }
                        Console.WriteLine($"[{string.Join(", ", resultArray)}]");
                        break;
                }

                inpute = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", arrayNumbers)}]");
        }

        private static int[] GetLastCount(int[] arrayNumbers, int count, int evenOrOdd)
        {
            int[] arreyResult = new int[count];

            int counter = 0;

            for (int i = arrayNumbers.Length - 1; i >= 0; i--)
            {
                if (arrayNumbers[i] % 2 == evenOrOdd && counter < count)
                {
                    arreyResult[counter] = arrayNumbers[i];
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

        private static int[] GetFirstCount(int[] arrayNumbers, int count, int evenOrOdd)
        {
            int[] arreyResult = new int[count];

            int counter = 0;

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                if (arrayNumbers[i] % 2 == evenOrOdd && counter < count)
                {
                    arreyResult[counter] = arrayNumbers[i];
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

        private static int GetMinIndex(int[] arrayNumbers, int evenOrOdd)
        {
            int minNumber = int.MaxValue;
            int index = -1;

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                if (arrayNumbers[i] <= minNumber && arrayNumbers[i] % 2 == evenOrOdd)
                {
                    minNumber = arrayNumbers[i];
                    index = i;
                }
            }
            return index;
        }

        private static int GetMaxIndex(int[] arrayNumbers, int evenOrOdd)
        {
            int maxNumber = int.MinValue;
            int index = -1;

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                if (arrayNumbers[i] >= maxNumber && arrayNumbers[i] % 2 == evenOrOdd)
                {
                    maxNumber = arrayNumbers[i];
                    index = i;
                }
            }
            return index;
        }

        private static void ExchangeNumbers(int[] arrayNumbers, int index)
        {
            for (int i = 0; i < index + 1; i++)
            {
                int firstNumber = arrayNumbers[0];

                for (int j = 0; j < arrayNumbers.Length - 1; j++)
                {
                    arrayNumbers[j] = arrayNumbers[j + 1];
                }

                arrayNumbers[arrayNumbers.Length - 1] = firstNumber;
            }
        }
    }
}
