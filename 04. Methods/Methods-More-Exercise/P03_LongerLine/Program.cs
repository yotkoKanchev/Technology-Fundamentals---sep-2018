using System;

namespace P03_LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            if (FindLineLength(x1,y1,x2,y2) >= FindLineLength(x3,y3,x4,y4))
            {
                if (FindDistanceToCenter(x1,y1) <= FindDistanceToCenter(x2,y2))
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                if (FindDistanceToCenter(x3, y3) <= FindDistanceToCenter(x4, y4))
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }

        public static double FindLineLength(double x, double y, double xx, double yy)
        {
            double lineLenth = Math.Sqrt(Math.Abs(Math.Pow(Math.Abs(x-xx), 2)) + Math.Abs(Math.Pow(Math.Abs(y-yy), 2)));
            return lineLenth;
        }
        public static double FindDistanceToCenter(double x, double y)
        {
            double distance = Math.Sqrt(Math.Abs(Math.Pow(x, 2)) + Math.Abs(Math.Pow(y, 2)));
            return distance;
        }
    }
}
