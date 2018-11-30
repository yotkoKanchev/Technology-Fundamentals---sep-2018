using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int num = number;
            int sum = 0;
            while (num > 0)
            {
                int dig = num % 10;
                int factorielNum = 1;

                do
                {
                    if (dig == 0)
                    {
                        dig = 1;
                    }
                    factorielNum = factorielNum * dig;
                    dig--;
                } while (dig > 0);
                sum += factorielNum;
                num /= 10;
            }
            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
