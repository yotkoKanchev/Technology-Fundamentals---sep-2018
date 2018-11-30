using System;

namespace P05_AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(AddAndSubtractNumbers(firstNumber,secondNumber,thirdNumber));
        }

        public static int AddAndSubtractNumbers(int firstNum,int secondNum ,int thirdNum)
        {
            return firstNum + secondNum - thirdNum;
        }
    }
}
