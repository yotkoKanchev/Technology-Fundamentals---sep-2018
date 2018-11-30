using System;

namespace _03._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            string[] firstArray = new string[numberOfLines];
            string[] secondArray = new string[numberOfLines];

            int counter = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] inputline = Console.ReadLine().Split();
                if (counter % 2 == 0)
                {
                    firstArray[i] = inputline[0];
                    secondArray[i] = inputline[1];
                }
                else
                {
                    firstArray[i] = inputline[1];
                    secondArray[i] = inputline[0];
                }
                counter++;
            }
            Console.WriteLine(string.Join(" ",firstArray));
            Console.WriteLine(string.Join(" ",secondArray));
        }
    }
}
