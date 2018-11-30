using System;

namespace P06_CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(CalculateTriangleArea(width,height));
        }

        private static double CalculateTriangleArea(double width, double height)
        {
            double triangleArea = width * height;
            return triangleArea;
        }
    }
}
