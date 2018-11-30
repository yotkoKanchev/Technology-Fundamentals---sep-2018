using System;

namespace P03
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int numberOfStudents = int.Parse(Console.ReadLine());
            decimal floorPrice = decimal.Parse(Console.ReadLine());
            decimal eggPrice = decimal.Parse(Console.ReadLine());
            decimal apronPrice = decimal.Parse(Console.ReadLine());


            decimal floorMoney = floorPrice * (numberOfStudents - (numberOfStudents / 5));
            decimal eggsMoney = eggPrice * numberOfStudents * 10;
            decimal apronMoney = apronPrice * Math.Ceiling(numberOfStudents * 1.2m);

            decimal totalMoneyNeeded = floorMoney + eggsMoney + apronMoney;

            if (budget >= totalMoneyNeeded)
            {
                Console.WriteLine($"Items purchased for {totalMoneyNeeded:f2}$.");
            }
            else
            {
                Console.WriteLine($"{(totalMoneyNeeded - budget):f2}$ more needed.");
            }
        }
    }
}
