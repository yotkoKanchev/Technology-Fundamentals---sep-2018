﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());

            if (letter >= 'A' && letter <= 'Z')
            {
                Console.WriteLine("upper-case");
            }
            else if (letter >= 'a' && letter <= 'z')
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
