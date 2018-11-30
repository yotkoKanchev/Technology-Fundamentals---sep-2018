using System;
using System.Text;


namespace P05_MultiplyBigNumber
{
    class Program
    {
        public static object StrigBuilder { get; private set; }

        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine().TrimStart('0');

            int inputLineLen = inputLine.Length;
            int multiplyBy = int.Parse(Console.ReadLine());
            
            if (multiplyBy == 0)
            {
                Console.WriteLine(0);
                return;
            }  

            int digit = 0;
            int digitToAdd = 0;

            StringBuilder sb = new StringBuilder();
            string test = sb.ToString();

            for (int i = inputLineLen - 1; i >= 0; i--)
            {
                int additionalDigit = 0;
                digit = (int.Parse(inputLine[i].ToString()) * multiplyBy) % 10;
                if (digit + digitToAdd > 9)
                {
                    sb.Append((digit + digitToAdd) % 10);
                    additionalDigit = (digit + digitToAdd) / 10;
                }
                else
                {
                    sb.Append(digit + digitToAdd);
                }                

                digitToAdd = (int.Parse(inputLine[i].ToString()) * multiplyBy) / 10 + additionalDigit;

                if (i == 0 && digitToAdd != 0)
                {
                    sb.Append(digitToAdd);
                }
            }
            
            StringBuilder sb1 = new StringBuilder();

            for (int i = sb.Length - 1; i >= 0; i--)
            {
                sb1.Append(sb[i]);
            }

            Console.WriteLine(sb1);
        }
    }
}
