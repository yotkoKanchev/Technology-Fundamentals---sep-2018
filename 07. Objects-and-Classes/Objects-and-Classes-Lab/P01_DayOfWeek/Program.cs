using System;
using System.Globalization;

namespace P01._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            DateTime dateAsString = DateTime.ParseExact(inputString, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(dateAsString.DayOfWeek);
        }
    }
}
