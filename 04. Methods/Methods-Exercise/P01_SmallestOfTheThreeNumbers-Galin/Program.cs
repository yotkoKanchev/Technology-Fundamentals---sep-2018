using System;

namespace P01_Galin
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int smallerNumber = SmallerNumber(firstNumber, secondNumber);

            int result = SmallerNumber(smallerNumber, thirdNumber);

            Console.WriteLine(result);
        }
        static int SmallerNumber(int firstNum, int seconNum)
        {
            return firstNum <= seconNum ? firstNum : seconNum;
        }
    }
}
