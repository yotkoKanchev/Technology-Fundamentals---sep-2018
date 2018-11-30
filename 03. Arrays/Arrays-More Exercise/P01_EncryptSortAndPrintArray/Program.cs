using System;
using System.Collections.Generic;

namespace P01._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStrings = int.Parse(Console.ReadLine());

            List<int> resultList = new List<int>();
            for (int i = 0; i < numberOfStrings; i++)
            {
                string inputString = Console.ReadLine();

                int stringLenght = inputString.Length;

                int vowelsSum = 0;
                int consonantsSum = 0;

                foreach (var letter in inputString)
                {
                    if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u'
                        || letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
                    {
                        vowelsSum += letter * stringLenght;
                    }
                    else
                    {
                        consonantsSum += letter / stringLenght;
                    }
                }

                resultList.Add(vowelsSum + consonantsSum);
            }
            resultList.Sort();
            foreach (var number in resultList)
            {
                Console.WriteLine(number);
            }
        }
    }
}
