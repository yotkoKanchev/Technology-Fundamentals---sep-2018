using System;

namespace P09_MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            int printResult = GetMultiplyOfEvenAndOdds(GetSumOfEvenDigits(number), GetSumOfOddDigits(number));
            Console.WriteLine(printResult);
        }

        private static int GetSumOfEvenDigits(int number)
        {
            int evenSum = 0;

            while (number>0)
            {
                if ((number % 10 )% 2 == 0)
                {
                    evenSum += number % 10;
                }
                    number /= 10;
            }
            return evenSum;
        }

        private static int GetSumOfOddDigits(int number)
        {
            int oddSum = 0;

            while (number > 0)
            {
                if ((number % 10) %2 == 1)
                {
                    oddSum += number % 10;
                }
                number /= 10;
            }
            return oddSum;
        }

        private static int GetMultiplyOfEvenAndOdds(int sumOfEvenDigits, int sumOfOddDigits)
        {
            int printResult = sumOfEvenDigits * sumOfOddDigits;
            return printResult;
        }
    }
}
