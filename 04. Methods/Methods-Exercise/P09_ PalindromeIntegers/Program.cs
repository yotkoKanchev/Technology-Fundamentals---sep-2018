using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P09_9._PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input!= "END")
            {
                Console.WriteLine(FindPalindrome(input));

                input = Console.ReadLine();
            }
        }

        public static string FindPalindrome(string text)
        {
            string result = string.Empty;

            StringBuilder reversedText = new StringBuilder();
            for (int i = text.Length-1; i >=0 ; i--)
            {
                reversedText.Append(text[i]);
            }

            if (text == reversedText.ToString()) 
            {
                result = "true";
            }
            else
            {
                result = "false";
            }
            return result;
        }
    }
}
