using System;
using System.Linq;

namespace P05_Galin
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine().TrimStart('0');

            int secondNumber = int.Parse(Console.ReadLine());
            int onMind = 0;

            string reversedNumber = string.Join("", firstNumber.ToCharArray().Reverse());

            string resultNumber = string.Empty;
            for (int i = 0; i < reversedNumber.Length; i++)
            {
                int firstDigit = int.Parse(reversedNumber[i].ToString());

                int result = firstDigit * secondNumber + onMind;

                resultNumber += result % 10;

                onMind = result / 10;

                if (i == reversedNumber.Length-1 && onMind != 0)
                {
                    resultNumber += onMind;
                }
            }

            string finalResult = string.Join("", resultNumber.ToCharArray().Reverse());

            Console.WriteLine(finalResult);
        }
    }
}
