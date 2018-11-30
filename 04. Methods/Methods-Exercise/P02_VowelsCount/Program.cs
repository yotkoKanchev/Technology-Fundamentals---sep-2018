using System;

namespace P02_VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine().ToLower();

            Console.WriteLine(GetNumberOfVowels(inputString));
        }

        private static int GetNumberOfVowels(string data)
        {
            int result = 0;

            foreach (var letter in data)
            {
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u') 
                {
                    result++;
                }
            }

            return result;
        }
    }
}
