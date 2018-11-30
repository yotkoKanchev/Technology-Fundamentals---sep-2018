using System;
using System.Collections.Generic;

namespace P01_Galin
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            List<string> validUsernames = new List<string>();

            for (int i = 0; i < usernames.Length; i++)
            {
                string username = usernames[i];

                if (username.Length >= 3 && username.Length <= 16)
                {
                    bool validateContent = ValidateUsernameContent(username);

                    if (validateContent == true)
                    {
                        validUsernames.Add(usernames[i]);
                    }
                }
            }

            foreach (var item in validUsernames)
            {
                Console.WriteLine(item);
            }
        }

        private static bool ValidateUsernameContent(string username)
        {
            foreach (var symbol in username)
            {
                if (char.IsLetterOrDigit(symbol) || symbol == '_' || symbol == '-')
                {
                    continue;
                }
                else
                {
                    return false;
                }                
            }
            return true;
        }
    }
}
