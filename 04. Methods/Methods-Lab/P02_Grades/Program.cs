using System;

namespace P02_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            PrintGradeInWords(grade);
        }

        static void PrintGradeInWords(double number)
        {
            if (number >= 2 && number < 3)
            {
                Console.WriteLine($"Fail");
            }
            else if (number >=3 && number < 3.50)
            {
                Console.WriteLine("Poor");
            }
            else if (number>= 3.50 && number < 4.50)
            {
                Console.WriteLine("Good");
            }
            else if (number>= 4.50 && number < 5.50)
            {
                Console.WriteLine("Very good");
            }
            else if (number>= 5.50 && number <=6)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
