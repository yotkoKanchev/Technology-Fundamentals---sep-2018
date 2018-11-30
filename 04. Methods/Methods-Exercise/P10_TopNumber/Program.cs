using System;

namespace P10_TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 17; i < number; i++)
            {
                if (CheckIfDevisableByEight(i) == true && CheckIfOddDigitExist(i) == true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool CheckIfDevisableByEight(int number)
        {
            int sum = 0;
            bool isDevisable = false;
            while (number>0)
            {
                sum += number % 10;
                number /= 10;
            }

            if (sum % 8 == 0)
            {
                isDevisable = true;
            }
            return isDevisable;
        }

        public static bool CheckIfOddDigitExist(int number)
        {
            bool oddDigitExist = false;

            while (number>0)
            {
                if ((number % 10) % 2 != 0)
                {
                    oddDigitExist = true;
                }
                number /= 10;
            }

            return oddDigitExist;
        }
    }
}
