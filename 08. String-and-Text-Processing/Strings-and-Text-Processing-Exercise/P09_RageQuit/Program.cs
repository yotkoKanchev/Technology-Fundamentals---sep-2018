using System;
using System.Linq;
using System.Text;

namespace P09_RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine().ToUpper();

            StringBuilder sb = new StringBuilder();
            int startIndex = 0;

            for (int i = 0; i < inputLine.Length; i++)  
                {
                int digitIndex = 0;
                if (char.IsDigit(inputLine[i]))
                {
                    int repeats = 0;
                    bool incrementI = false;
                    if (i < inputLine.Length-1 && char.IsDigit(inputLine[i+1]))
                    {
                        repeats = int.Parse(inputLine.Substring(i, 2));
                        incrementI = true;
                    }
                    else
                    {
                        repeats = int.Parse(inputLine[i].ToString());                        
                    }

                    digitIndex = i - startIndex;

                    for (int j = 0; j < repeats; j++)
                    {
                        sb.Append((inputLine.Substring(startIndex, digitIndex)));
                    }
                    startIndex = i+1;
                    if (incrementI == true)
                    {
                        i++;
                        startIndex++;
                    }
                }
            }

            string resulString = sb.ToString();
            char [] symbols = resulString.ToCharArray().Distinct().ToArray();

            Console.WriteLine($"Unique symbols used: {symbols.Length}");
            Console.WriteLine(sb);

        }
    }
}
