using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var pitagor = new List<int>();

            pitagor.Add(1);
            pitagor.Add(1);
            if (n == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(1);
                Console.WriteLine($"1 1");
            }

            for (int i = 0; i < n - 2; i++)
            {
                var resultList = new List<int>();

                for (int k = 0; k < pitagor.Count; k++)
                {
                    resultList.Add(pitagor[k]);
                }
                pitagor.Insert(pitagor.Count - 1, 1);
                for (int j = 1; j < pitagor.Count-1; j++)
                {
                    resultList[j] = pitagor[j] + pitagor[j - 1];
                }
                
                for (int p = 0; p < resultList.Count; p++)
                {
                    pitagor[p] = resultList[p];
                }
                Console.Write(string.Join(" ", pitagor));
                Console.WriteLine();
            }
        }
    }
}
