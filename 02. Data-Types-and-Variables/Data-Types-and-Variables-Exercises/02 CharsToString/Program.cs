using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstInput = char.Parse(Console.ReadLine());
            char secondInput = char.Parse(Console.ReadLine());
            char thirdInput = char.Parse(Console.ReadLine());

            Console.WriteLine($"{firstInput}{secondInput}{thirdInput}");
        }
    }
}
