using System;

namespace P09_Galin
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string word = Console.ReadLine();
                if (word == "END")
                {
                    break;
                }
                
                string reversedWord = string.Empty;

                for (int i = word.Length-1; i >= 0; i--)
                {
                    reversedWord += word[i];
                }

                bool isPalindrom = Palindrom(word, reversedWord);

                Console.WriteLine(isPalindrom == true? "true" : "false");
            }       

        }

        private static bool Palindrom(string word, string reversedWord)
        {
            return word == reversedWord;
        }
    }
}
