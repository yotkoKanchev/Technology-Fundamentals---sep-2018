using System;

namespace P07_MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = Math.Abs(double.Parse(Console.ReadLine()));
            double power = Math.Abs(double.Parse(Console.ReadLine()));

            Console.WriteLine(CalculatePowerOfNumber(number,power));
        }

        private static double CalculatePowerOfNumber(double number, double power)
        {
            double result = Math.Pow(number, power);

            return result;
        }
    }
}
