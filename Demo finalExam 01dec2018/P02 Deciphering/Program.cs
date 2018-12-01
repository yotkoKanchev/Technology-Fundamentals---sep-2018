using System;
using System.Text.RegularExpressions;

namespace P02_Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();

            string regex = @"^([d-z,|#{}]*)$";

            var matches = Regex.Matches(encryptedMessage, regex);

            string validEncrypedMessage = string.Empty;

            foreach (Match match in matches)
            {
                validEncrypedMessage = match.Value;
            }

            if (validEncrypedMessage != string.Empty)
            {
                string reducedBy3Message = string.Empty;

                foreach (var letter in encryptedMessage)
                {
                    reducedBy3Message += (char)((char)letter - 3);
                }

                string[] lettersOrSubstring = Console.ReadLine().Split();

                string textToFind = lettersOrSubstring[0];
                string textToChangeWith = lettersOrSubstring[1];

                reducedBy3Message = reducedBy3Message.Replace(textToFind, textToChangeWith);

                Console.WriteLine(reducedBy3Message);
            }
            else
            {
                Console.WriteLine("This is not the book you are looking for.");
            }
        }
    }
}
