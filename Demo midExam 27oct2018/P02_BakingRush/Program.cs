using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_BakingRush
{
    class Program
    {
        static void Main(string[] args)
        {
            int coins = 100;
            int energy = 100;

            List<string> ordersList = Console.ReadLine().Split("|").ToList();

            for (int i = 0; i < ordersList.Count; i++)
            {
                string[] tokens = ordersList[i].Split("-");

                string command = tokens[0];
                int number = int.Parse(tokens[1]);
                if (number < 0)
                {
                    break;
                }
                if (coins <= 0)
                {
                    break;
                }
                switch (command)
                {
                    case "rest":
                        
                        if (energy + number <= 100)
                        {                            
                            Console.WriteLine($"You gained {number} energy.");
                            energy+= number;
                            Console.WriteLine($"Current energy: {energy}.");
                        }
                        else
                        {
                            Console.WriteLine("You gained 0 energy.");
                            Console.WriteLine($"Current energy: {energy}.");
                        }
                        break;

                    case "order":
                        if (energy >= 30)
                        {
                            Console.WriteLine($"You earned {number} coins.");
                            energy -= 30;
                            coins += number;
                        }
                        else
                        {
                            Console.WriteLine($"You had to rest!");
                            energy += 50;
                        }
                        break;

                    default:
                        if (coins - number > 0)
                        {
                            Console.WriteLine($"You bought {command}.");
                            coins -= number;
                        }
                        else
                        {
                            Console.WriteLine($"Closed! Cannot afford {command}.");
                            coins = 0;
                            break;
                        }
                        break;
                }
            }

            if (coins > 0)
            {
                Console.WriteLine($"Day completed!");
                Console.WriteLine($"Coins: {coins}");
                Console.WriteLine($"Energy: {energy}");
            }
        }
    }
}
