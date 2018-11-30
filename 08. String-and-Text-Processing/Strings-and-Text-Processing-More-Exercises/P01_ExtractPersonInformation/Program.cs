using System;

namespace P01_ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int nameStartIndex = 0;
                int nameEndIndex = 0;
                

                int ageStartIndex = 0;
                int ageEndIndex = 0;
                

                string inputString = Console.ReadLine();
                for (int j = 0; j < inputString.Length; j++)
                {
                    if (inputString[j] == '@')
                    {
                        nameStartIndex = j+1;

                        for (int k = j; k < inputString.Length; k++)
                        {
                            if (inputString[k] == '|')
                            {
                                nameEndIndex = k;
                                break;
                            }
                        }
                    }
                    else if (inputString[j] == '#')
                    {
                        ageStartIndex = j+1;

                        for (int k = j; k < inputString.Length; k++)
                        {
                            if (inputString[k] == '*')
                            {
                                ageEndIndex = k;
                                break;
                            }
                        }
                    }
                }
                int nameLen = nameEndIndex - nameStartIndex;
                int ageLen = ageEndIndex - ageStartIndex;
                string name = inputString.Substring(nameStartIndex, nameLen);
                string age = inputString.Substring(ageStartIndex, ageLen);
                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
