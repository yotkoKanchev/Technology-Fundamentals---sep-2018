using System;

namespace P01._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[7]
                {
                    "Monday",
                    "Tuesday",
                    "Wednesday",
                    "Thursday",
                    "Friday",
                    "Saturday",
                    "Sunday",
                };

            int number = int.Parse(Console.ReadLine());
            if (number<1 || number > 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(days[number-1]);
            }
        }
    }
}
