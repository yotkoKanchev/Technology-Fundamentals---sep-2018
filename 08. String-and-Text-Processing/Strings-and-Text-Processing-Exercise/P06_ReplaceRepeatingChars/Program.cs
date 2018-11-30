using System;
using System.Linq;

namespace P06_ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();

            for (int i = 1; i < inputData.Length; i++)
            {
                if (inputData[i] == inputData[i-1])
                {
                    inputData = inputData.Remove(i,1);
                    i--;
                }
            }
            Console.WriteLine(inputData);
        }
    }
}
