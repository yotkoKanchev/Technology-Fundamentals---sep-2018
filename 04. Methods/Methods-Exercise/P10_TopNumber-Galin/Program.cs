using System;

namespace P10_Galin
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            for (int i = 8; i < range; i++)
            {
                int num = i;

                bool isDivisableByEight = CheckIsDivisableByEight(i);

                bool containsOddnumber = ContainsOddNumber(i);

                if (isDivisableByEight && containsOddnumber)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool ContainsOddNumber(int number)
        {
            while (number != 0)
            {
                int digit = number % 10;
                number /= 10;

                if (digit % 2 == 1)
                {
                    return true;
                }                
            }
            return false;
        }

        private static bool CheckIsDivisableByEight(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int digit = number % 10;
                number /= 10;

                sum += digit;
            }

            if (sum % 8 == 0)
            {
                return true;
            }

            return false;
        }
    }
}
