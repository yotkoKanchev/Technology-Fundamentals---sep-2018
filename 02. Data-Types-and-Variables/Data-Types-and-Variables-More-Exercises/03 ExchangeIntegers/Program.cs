using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03ExchangeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int oldFirsNumber = firstNumber;
            int oldSecondNumber = secondNumber;

            firstNumber = secondNumber;
            secondNumber = oldFirsNumber;

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {oldFirsNumber}");
            Console.WriteLine($"b = {oldSecondNumber}");
            Console.WriteLine("After:");
            Console.WriteLine($"a = {firstNumber}");
            Console.WriteLine($"b = {secondNumber}");
        }
    }
}
