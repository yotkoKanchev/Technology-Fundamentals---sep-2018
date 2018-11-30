using System;
using System.Numerics;

namespace P08_FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger firstNumber = BigInteger.Parse(Console.ReadLine());
            BigInteger secondNumber =BigInteger.Parse(Console.ReadLine());

            Console.WriteLine($"{GetFactorielDivision(firstNumber,secondNumber):f2}");
        }

        public static decimal GetFactorielDivision(BigInteger num1, BigInteger num2)
        {
            return GetFactoriel(num1) / GetFactoriel(num2);
        }

        public static decimal GetFactoriel(BigInteger num)
        {
            decimal result = 1;

            if (num == 0)
            {
               result = 1;
            }
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    result *= i;
                }
            }            
            return result;
        }
    }
}
