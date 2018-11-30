using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double studentsCount = double.Parse(Console.ReadLine());
            double sabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double totalMoney = sabersPrice * Math.Ceiling(studentsCount + 0.1 * studentsCount) + robesPrice * studentsCount + beltsPrice * Math.Ceiling(studentsCount - studentsCount / 6);

            if (totalMoney <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(totalMoney-money):f2}lv more.");
            }
        }
    }
}
