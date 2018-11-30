using System;

namespace P06_MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();
            Console.WriteLine(PrintMiddleCharacter(inputData));
        }

        public static string PrintMiddleCharacter(string text)
        {
            string result = string.Empty;

            if (text.Length % 2 != 0)
            {
                result = text[text.Length / 2].ToString();
            }
            else
            {
                result = text[text.Length / 2 - 1].ToString() + text[text.Length / 2].ToString();
            }

            return result;
        }
    }
}
