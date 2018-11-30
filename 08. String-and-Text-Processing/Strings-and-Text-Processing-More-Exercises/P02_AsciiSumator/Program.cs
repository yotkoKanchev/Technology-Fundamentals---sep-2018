using System;

namespace P02_AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char startChar = char.Parse(Console.ReadLine());
            char endChar = char.Parse(Console.ReadLine());

            string inputData = Console.ReadLine();

            int charSum = 0;

            for (int i = 0; i < inputData.Length; i++)
            {
                if (inputData[i] > startChar && inputData[i] < endChar)
                {
                    charSum += inputData[i];
                }
            }                      

            Console.WriteLine(charSum);
        }
    }
}
