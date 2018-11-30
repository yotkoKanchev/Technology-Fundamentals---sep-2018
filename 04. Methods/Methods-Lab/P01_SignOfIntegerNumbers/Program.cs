﻿using System;

namespace P01_SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSign(int.Parse(Console.ReadLine()));
        }

        static void PrintSign(int number)
        {
            if (number<0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }

            else if (number>0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }

            else
            {
                Console.WriteLine("The number 0 is zero.");
            }
        }
    }
}
