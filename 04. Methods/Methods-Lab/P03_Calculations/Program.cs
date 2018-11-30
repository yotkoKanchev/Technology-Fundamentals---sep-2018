using System;

namespace P03_Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine().ToLower();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    AddNumbers(firstNumber, secondNumber);
                    break;
                case "multiply":
                    MultiplyNumbers(firstNumber, secondNumber);
                    break;
                case "subtract":
                    SubtractNumbers(firstNumber, secondNumber);
                    break;
                case "divide":
                    DivideNumbers(firstNumber, secondNumber);
                    break;
            }
        }

        private static void AddNumbers(int firstNum,int seconNum)
        {
            Console.WriteLine(firstNum+seconNum);
        }

        private static void MultiplyNumbers(int firsNum, int secondNum)
        {
            Console.WriteLine(firsNum * secondNum);
        }

        private static void SubtractNumbers(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum-secondNum);
        }

        private static void DivideNumbers(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum / secondNum);
        }
    }
}
