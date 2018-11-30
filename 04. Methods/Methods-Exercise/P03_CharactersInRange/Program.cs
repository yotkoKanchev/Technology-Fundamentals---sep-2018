using System;

namespace P03_CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstSimbol = char.Parse(Console.ReadLine());
            char secondSimbol = char.Parse(Console.ReadLine());

            Console.WriteLine(GetSimbolsBetween(firstSimbol,secondSimbol));
        }

        private static string GetSimbolsBetween(char firstChar, char secondChar)
        {

            if (firstChar > secondChar)
            {
                char oldFirstChar = firstChar;
                firstChar = secondChar;
                secondChar = oldFirstChar;
            }
            string result = string.Empty;
            for (int i = firstChar + 1; i < secondChar; i++)
            {
                result += (char)i + " ";
            }
            return result;
        }
    }
}
