using System;

namespace P11_MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine(CalculateResult(firstNumber, @operator, secondNumber));
        }

        private static double CalculateResult(double firstNum, string @operator, double secondNum)
        {
            double result = 0;
            switch (@operator)
            {
                case "/":
                    result = firstNum / secondNum;
                    break;
                case "*":
                    result = firstNum * secondNum;
                    break;
                case "+":
                    result = firstNum + secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
            }

            return result;
        }
    }
}
