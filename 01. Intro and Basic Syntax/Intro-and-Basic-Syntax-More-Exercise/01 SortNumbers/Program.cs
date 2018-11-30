using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int minNum = 0;
            int midNum = 0;
            int maxNum = 0;
            if (firstNum > secondNum && firstNum > thirdNum)
            {
                maxNum = firstNum;
                if (secondNum > thirdNum)
                {
                    midNum = secondNum;
                    minNum = thirdNum;
                }
                else
                {
                    midNum = thirdNum;
                    minNum = secondNum;
                }
            }
            else if (secondNum > firstNum && secondNum > thirdNum)
            {
                maxNum = secondNum;
                if (firstNum > thirdNum)
                {
                    midNum = firstNum;
                    minNum = thirdNum;
                }
                else
                {
                    midNum = thirdNum;
                    minNum = firstNum;
                }
            }
            else if (thirdNum > firstNum && thirdNum > secondNum)
            {
                maxNum = thirdNum;
                if (firstNum > secondNum)
                {
                    midNum = firstNum;
                    minNum = secondNum;
                }
                else
                {
                    midNum = secondNum;
                    minNum = firstNum;
                }
            }
            Console.WriteLine(maxNum);
            Console.WriteLine(midNum);
            Console.WriteLine(minNum);
        }
    }
}
