using System;

namespace P08_LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputLine = Console.ReadLine()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            decimal totalSum = 0m;

            for (int i = 0; i < inputLine.Length; i++)
            {                
                string line = inputLine[i];
                char firstSymbol = line[0];
                char lastSymbol = line[line.Length - 1];

                int position = 0;
                if (char.IsUpper(firstSymbol))
                {
                    position = (int)(firstSymbol - 64);
                    totalSum += decimal.Parse(line.Substring(1, line.Length - 2)) / position;
                }
                else
                {
                    position = (int)(firstSymbol - 96);
                    totalSum += decimal.Parse(line.Substring(1, line.Length - 2)) * position;
                }

                if (char.IsUpper(lastSymbol))
                {
                    position = (int)(lastSymbol - 64);
                    totalSum -= position;
                }
                else
                {
                    position = (int)(lastSymbol - 96);
                    totalSum += position;
                }
            }
            
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
