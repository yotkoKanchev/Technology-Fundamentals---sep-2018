using System;
using System.Numerics;

namespace P05_MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num1 = BigInteger.Parse(Console.ReadLine());
            BigInteger num2 = BigInteger.Parse(Console.ReadLine());
            BigInteger num3 = BigInteger.Parse(Console.ReadLine());
            if (num1 != 0 && num2 != 0 && num3 != 0)
            {
                Console.WriteLine(FindPositiveOrNegative(num1, num2, num3));

            }
            else
            {
                Console.WriteLine("zero");
            }
        }

        public static string FindPositiveOrNegative(BigInteger num1, BigInteger num2, BigInteger num3)
        {
            BigInteger[] numbers = { num1, num2, num3 };

            int negativeCounter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]  < 0)
                {
                    negativeCounter++;
                }
            }
            string result = string.Empty;

            if (negativeCounter % 2 == 0)
            {
                result = "positive";
            }
            else
            {
                result = "negative";
            }

            return result;
        }
    }
}
