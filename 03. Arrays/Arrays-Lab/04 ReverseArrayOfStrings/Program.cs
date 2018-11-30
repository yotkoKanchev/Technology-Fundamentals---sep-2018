using System;

namespace P04._11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = Console.ReadLine().Split();

            Array.Reverse(myArray);

            Console.WriteLine(string.Join(" ",myArray));                
        }
    }
}
