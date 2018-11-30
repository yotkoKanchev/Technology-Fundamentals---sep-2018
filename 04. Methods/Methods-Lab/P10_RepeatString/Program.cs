using System;
using System.Text;

namespace P09_RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            int repeats = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatStringNTimes(data, repeats));
        }

        private static string RepeatStringNTimes(string data, int numberOfRepeats)
        {
            StringBuilder resultString = new StringBuilder();

            for (int i = 0; i < numberOfRepeats; i++)
            {
                resultString.Append(data);
            }

            return resultString.ToString();
        }
    }
}
