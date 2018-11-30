using System;

namespace P02_CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string firstString = inputLine.Split()[0];
            string secondString = inputLine.Split()[1];

            int sum = 0;
            if (firstString.Length > secondString.Length)
            {
                for (int i = 0; i < secondString.Length; i++)
                {
                    sum += (char)firstString[i] * (char)secondString[i];
                }

                for (int i = secondString.Length; i < firstString.Length; i++)
                {
                    sum += (char)firstString[i];
                }
            }
            else if (secondString.Length > firstString.Length)
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    sum += (char)firstString[i] * (char)secondString[i];

                }

                for (int i = firstString.Length; i < secondString.Length; i++)
                {
                    sum += (char)secondString[i];
                }
            }
            else
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    sum += (char)firstString[i] * (char)secondString[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
