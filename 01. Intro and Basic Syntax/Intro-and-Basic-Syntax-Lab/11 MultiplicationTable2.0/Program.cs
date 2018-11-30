using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplayer = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            if (n > 10)
            {
                Console.WriteLine($"{multiplayer} X {n} = {multiplayer * n}");
            }
            for (int i = n; i <= 10; i++)
            {
                Console.WriteLine($"{multiplayer} X {i} = {multiplayer * i}");
            }
        }
    }
}
