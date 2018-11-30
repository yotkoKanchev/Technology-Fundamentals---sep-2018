using System;
using System.Linq;

namespace P01_SmallestOfTheThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(GetSmallestNumber(firstNumber, secondNumber, thirdNumber));
        }

        private static int GetSmallestNumber(int firstNum, int secondNum, int thirdsNum)
        {
            int[] resultArray = { firstNum, secondNum, thirdsNum };
            int result = resultArray.Min();

            return result;
        }
    }
}
