using System;
using System.Text;

namespace P04_CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < inputData.Length; i++)
            {
                sb.Append((char)((char)inputData[i] + 3));
            }

            Console.WriteLine(sb);
        }
    }
}
