using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal startBalance = decimal.Parse(Console.ReadLine());
            decimal balance = startBalance;
            string input = Console.ReadLine();

            decimal gamePrice = 0m;
            while (input != "Game Time")
            {
                string gameName = input;
                switch (gameName)
                {
                    case "OutFall 4":
                        gamePrice = 39.99m;
                        break;
                    case "CS: OG":
                        gamePrice = 15.99m;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99m;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99m;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99m;
                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99m;
                        break;
                    default:
                        Console.WriteLine($"Not Found");
                        break;
                }



                if (gamePrice > balance)
                {
                    Console.WriteLine($"Too Expensive");
                }
                else if (gameName == "OutFall 4" || gameName == "CS: OG" || gameName == "Zplinter Zell" ||
                    gameName == "Honored 2" || gameName == "RoverWatch" || gameName == "RoverWatch Origins Edition")
                {
                    Console.WriteLine($"Bought {gameName}");
                    balance -= gamePrice;
                }
                if (balance <= 0)
                {
                    Console.WriteLine($"Out of money!");
                    return;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${(startBalance - balance):f2}. Remaining: ${balance:f2}");
        }
    }
}
