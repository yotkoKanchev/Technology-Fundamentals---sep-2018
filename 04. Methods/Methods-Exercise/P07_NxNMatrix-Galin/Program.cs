using System;

namespace P07_Galin
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeMatrix = int.Parse(Console.ReadLine());

            PrintMatrix(sizeMatrix);
            
        }

        static void PrintMatrix(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(size + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
