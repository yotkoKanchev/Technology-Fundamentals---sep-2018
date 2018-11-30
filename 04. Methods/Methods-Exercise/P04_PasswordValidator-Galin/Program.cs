using System;

namespace P04_Galin
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isBetween6And10Symbols = CheckLengthOfPassword(password);
            if (isBetween6And10Symbols == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters ");
            }

            bool containsOnlyDigitsAndLetters = ContainsOnlyDigitsAndLetters(password);

            if (containsOnlyDigitsAndLetters == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            bool containsMin2Digits = ChekMinDigits(password);

            if (containsMin2Digits == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isBetween6And10Symbols && containsOnlyDigitsAndLetters && containsMin2Digits)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool ChekMinDigits(string password)
        {
            int counter = 0;
            
            for (int i = 0; i < password.Length; i++)
            {
                char symbol = password[i];
                if (char.IsDigit(symbol))
                {
                    counter++;
                }
            }

            return counter >= 2 ? true : false;
        }

        private static bool ContainsOnlyDigitsAndLetters(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                char symbol = password[i];
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool CheckLengthOfPassword(string password)
        {
            return password.Length >= 6 && password.Length <= 10 ? true : false;
        }
    }
}
