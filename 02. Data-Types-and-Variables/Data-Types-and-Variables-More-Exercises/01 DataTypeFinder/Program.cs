using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                bool isBoolean = bool.TryParse(input, out bool boolean);
                bool isInteger = int.TryParse(input, out int integer);
                bool isCharacter = char.TryParse(input, out char chareacter);
                bool isFloatingPoint = double.TryParse(input, out double floatingPoint);

                if (isBoolean)
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else if (isInteger)
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (isCharacter)
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (isFloatingPoint)
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
            }
        }
    }
}
