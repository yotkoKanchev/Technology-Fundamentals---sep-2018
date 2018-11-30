using System;

namespace P08_Galin
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            long firstFactorial = Factorial(firstNumber);
            long secondFactorial = Factorial(secondNumber);

            double result = Divide(firstFactorial, secondFactorial);

            Console.WriteLine($"{result:f2}");
        }

        static double Divide(long num1,long num2)
        {
            return (double)num1 / num2;
        }

        private static long Factorial(long num)
        {
            long factorial = 1;

            for (int i = 2; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
