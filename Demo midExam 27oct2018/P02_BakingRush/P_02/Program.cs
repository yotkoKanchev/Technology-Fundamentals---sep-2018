using System;

namespace P02_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = 100;
            int coins = 100;


            string[] tokens = Console.ReadLine().Split("|");

            for (int i = 0; i < tokens.Length; i++)
            {
                string commandOrIngredient = tokens[i].Split("-")[0];
                int number = int.Parse(tokens[i].Split("-")[1]);

                switch (commandOrIngredient)
                {
                    case "rest":
                        if (energy + number <= 100)
                        {
                            Console.WriteLine($"You gained {number} energy.");
                            energy += number;
                            Console.WriteLine($"Current energy: {energy}.");
                        }
                        else
                        {
                            Console.WriteLine($"You gained {100 - energy} energy.");
                            energy = 100;
                            Console.WriteLine($"Current energy: {energy}.");
                        }
                        break;

                    case "order":
                        if (energy >= 30)
                        {
                            coins += number;
                            Console.WriteLine($"You earned {number} coins.");
                            energy -= 30;
                        }
                        else
                        {
                            energy += 50;
                            Console.WriteLine($"You had to rest!");                            
                        }
                        break;

                    default:
                        if (coins-number > 0)
                        {
                            Console.WriteLine($"You bought {commandOrIngredient}.");
                            coins -= number;
                        }
                        else
                        {
                            Console.WriteLine($"Closed! Cannot afford {commandOrIngredient}.");
                            return;
                        }
                        break;
                }
            }
            Console.WriteLine($"Day completed!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Energy: {energy}");
        }
    }
}
