using System;

namespace P03._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibonacciNumber = int.Parse(Console.ReadLine());
            if (fibonacciNumber == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                int[] myArray = new int[fibonacciNumber];
                myArray[0] = 1;
                myArray[1] = 1;

                for (int i = 2; i < fibonacciNumber; i++)
                {
                    myArray[i] = myArray[i - 1] + myArray[i - 2];
                }

                Console.WriteLine(myArray[fibonacciNumber - 1]);
            }            
        }
    }
}
