using System;

namespace P02_CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            if (FindDistance(x1,y1) <= FindDistance(x2,y2))
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");

            }
        }

        public static double FindDistance(double x, double y)
        {
            double distance = Math.Sqrt(Math.Abs(Math.Pow(x, 2)) + Math.Abs(Math.Pow(y, 2)));
            return distance;
        }
    }
}
