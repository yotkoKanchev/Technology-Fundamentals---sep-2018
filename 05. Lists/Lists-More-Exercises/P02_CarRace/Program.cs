using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> minutes = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();
            double firstCarTime = 0;
            double secondCarTime = 0;

            for (int i = 0; i < minutes.Count / 2; i++)
            {
                if (minutes[i] == 0)
                {
                    firstCarTime *= 0.8;
                }
                firstCarTime += minutes[i];
            }

            for (int i = minutes.Count-1; i > minutes.Count / 2; i--)
            {
                if (minutes[i] == 0)
                {
                    secondCarTime *= 0.8;
                }
                secondCarTime += minutes[i];
            }
            if (firstCarTime < secondCarTime)
            {
                Console.WriteLine($"The winner is left with total time: {firstCarTime}");
            }
            else if (secondCarTime < firstCarTime)
            {
                Console.WriteLine($"The winner is right with total time: {secondCarTime}");
            }
        
        }
    }
}
