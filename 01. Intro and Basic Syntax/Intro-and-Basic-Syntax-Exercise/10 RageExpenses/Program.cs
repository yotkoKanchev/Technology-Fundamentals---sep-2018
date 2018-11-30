using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double headsetMoney = (double)(lostGamesCount / 2) * headsetPrice;
            double mouseMoney = (double)(lostGamesCount / 3) * mousePrice;
            double keyboardMoney = (double)(lostGamesCount / 6) * keyboardPrice;
            double displayMoney = (double)(lostGamesCount / 12) * displayPrice;

            double totalMoney = headsetMoney + mouseMoney + keyboardMoney + displayMoney;

            Console.WriteLine($"Rage expenses: {totalMoney:f2} lv.");

        }
    }
}
