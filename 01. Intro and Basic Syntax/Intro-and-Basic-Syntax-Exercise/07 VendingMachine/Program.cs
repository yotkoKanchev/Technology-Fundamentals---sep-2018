using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            decimal coinSum = 0;
            while (input != "start")
            {
                decimal coin = decimal.Parse(input);

                if (coin == 0.1m || coin == 0.2m || coin == 0.5m || coin == 1m || coin == 2m)
                {
                    coinSum += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }

                input = Console.ReadLine().ToLower();
            }

            decimal itemPrice = 0;

            string newInput = Console.ReadLine().ToLower();


            while (newInput != "end")
            {
                
                switch (newInput)
                {
                    case "nuts":
                        itemPrice = 2.0m;
                        break;
                    case "water":
                        itemPrice = 0.7m;
                        break;
                    case "crisps":
                        itemPrice = 1.5m;
                        break;
                    case "soda":
                        itemPrice = 0.8m;
                        break;
                    case "coke":
                        itemPrice = 1.0m;
                        break;
                    default:
                        Console.WriteLine($"Invalid product");
                        break;
                }

                if (coinSum <= 0)
                {
                    break;
                }

                if (itemPrice > coinSum)
                {
                    Console.WriteLine($"Sorry, not enough money");                    
                }
                else if (newInput == "nuts" || newInput == "water" || newInput == "crisps" || newInput == "soda" || newInput == "coke")
                {
                    Console.WriteLine($"Purchased {newInput}");
                    coinSum -= itemPrice;
                }
                newInput = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Change: {coinSum:f2}");
        }
    }
}
