using System;
using System.Numerics;

namespace _02FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string arguments = Console.ReadLine();
                BigInteger firstNum = BigInteger.Parse(arguments.Split()[0]);
                BigInteger secondNum = BigInteger.Parse(arguments.Split()[1]);

                int sum = 0;
                if (firstNum > secondNum)
                {
                    foreach (var item in arguments.Split(' ')[0])
                    {
                        if (item =='-')
                        {
                            continue;
                        }
                        sum += int.Parse(item.ToString());
                    }                
                    Console.WriteLine(sum);
                }
                else
                {
                    foreach (var item in arguments.Split(' ')[1])
                    {
                        if (item == '-')
                        {
                            continue;
                        }
                        sum += int.Parse(item.ToString());
                    }
                    Console.WriteLine(sum);
                }
            }           
            
        }
    }
}
