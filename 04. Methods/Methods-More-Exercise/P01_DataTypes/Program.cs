using System;

namespace P01_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            string data = Console.ReadLine();

            switch (dataType)
            {
                case "int":
                    int number = int.Parse(data);
                    Console.WriteLine(FormatInput(number));
                    break;
                case "real":
                    double realNumber = double.Parse(data);
                    Console.WriteLine($"{FormatInput(realNumber):f2}");
                    break;
                case "string":
                    Console.WriteLine(FromatInput(data));
                    break;
            }
        }
        public static int FormatInput(int number)
        {
            return number * 2;
        }

        public static double FormatInput(double number)
        {
            return number * 1.5;
        }
        public static string FromatInput(string text)
        {
            string resultStirng = "$" + text + "$";
            return resultStirng;
        }
    }
}
