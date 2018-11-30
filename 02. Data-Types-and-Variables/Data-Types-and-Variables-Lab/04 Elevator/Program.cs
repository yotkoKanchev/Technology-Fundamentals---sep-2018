using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfpeople = int.Parse(Console.ReadLine());

            int capacity = int.Parse(Console.ReadLine());

            int courses = numberOfpeople / capacity;           

            if (numberOfpeople % capacity != 0)
            {
                courses += 1;
            }
            Console.WriteLine(courses);
        }
    }
}
