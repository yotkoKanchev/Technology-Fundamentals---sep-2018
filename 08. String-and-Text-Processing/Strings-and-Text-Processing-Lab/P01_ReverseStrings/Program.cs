using System;
using System.Text;

namespace P01_ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string word = inputLine;

                StringBuilder sb = new StringBuilder();

                for (int i = word.Length-1; i >= 0; i--)
                {
                    sb.Append(word[i]);
                }

                Console.WriteLine($"{inputLine} = {sb}");
                inputLine = Console.ReadLine();
            }
        }
    }
}
