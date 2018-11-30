using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());

            List<int> drumSet = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> workList = drumSet.ToList();

            string inputLine = Console.ReadLine();

            while (inputLine != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(inputLine);

                for (int i = 0; i < workList.Count; i++)
                {
                    if (workList[i] >= hitPower)
                    {
                        workList[i] -= hitPower;
                        if (workList[i] == 0)
                        {
                            if (money >= drumSet[i] * 3)
                            {
                                workList[i] = drumSet[i];
                                money -= workList[i] * 3;
                            }
                            else
                            {
                                workList.RemoveAt(i);
                                drumSet.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                    else
                    {
                        if (money >= drumSet[i] * 3)
                        {
                            workList[i] = drumSet[i];
                            money -= workList[i] * 3;
                        }
                        else
                        {
                            workList.RemoveAt(i);
                            drumSet.RemoveAt(i);
                            i--;
                        }                        
                    }
                }
                inputLine = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",workList));
            Console.WriteLine($"Gabsy has {money:f2}lv.");
        }
    }
}
