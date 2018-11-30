using System;

namespace P04_PasswordValidator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            bool correctLenght = false;

            if (CheckLenght(inputText))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            else
            {
                correctLenght = true;
            }

            bool correctContent = false;
            if (CheckForLettersAndDigits(inputText))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            else
            {
                correctContent = true;
            }

            bool hasTwoDigits = false;
            if (CheckIfStringHasAtLeastTwoDigits(inputText))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            else
            {
                hasTwoDigits = true;
            }

            if (correctContent && correctLenght && hasTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }                        
        }

        private static bool CheckLenght(string text)
        {
            bool incorrectLength = false;
            if (text.Length < 6 || text.Length > 10)
            {
                incorrectLength = true;
            }
            return incorrectLength;
        }

        private static bool CheckForLettersAndDigits(string text)
        {
            bool inccorectRule = false;
            foreach (var letter in text)
            {
                if ((letter >='A' && letter <= 'Z') || (letter >='a' && letter <='z') || (letter >= '0' && letter <= '9'))
                {
                    inccorectRule = false;                    
                }
                else
                {
                    inccorectRule = true;
                    break;
                }
            }
            return inccorectRule;
        }

        private static bool CheckIfStringHasAtLeastTwoDigits(string text)
        {
            bool incorrectRule = false;
            int digitCounter = 0;

            foreach (var digit in text)
            {
                bool IsDigit = int.TryParse(digit.ToString(), out int integer);

                if (IsDigit)
                {
                    digitCounter++;
                }
            }

            if (digitCounter < 2)
            {
                incorrectRule = true;
            }

            return incorrectRule;
        }
    }
}
