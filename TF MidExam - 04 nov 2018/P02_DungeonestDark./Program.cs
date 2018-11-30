using System;

namespace P02_DungeonestDark
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int coins = 0;

            string[] tokens = Console.ReadLine()
                .Split("|",StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < tokens.Length; i++)
            {
                string[] arguments = tokens[i].Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string commandOrMonster = arguments[0];
                int number = int.Parse(arguments[1]);

                switch (commandOrMonster)
                {
                    case "potion":
                        if (health + number <= 100)
                        {
                            Console.WriteLine($"You healed for {number} hp.");
                            health += number;
                            Console.WriteLine($"Current health: {health} hp.");
                        }
                        else
                        {
                            Console.WriteLine($"You healed for {100 - health} hp.");
                            health = 100;
                            Console.WriteLine($"Current health: {health} hp.");
                        }
                        break;

                    case "chest":
                        Console.WriteLine($"You found {number} coins.");
                        coins += number;
                        break;

                    default:
                        if (health - number > 0)
                        {
                            Console.WriteLine($"You slayed {commandOrMonster}.");
                            health -= number;
                        }
                        else
                        {
                            Console.WriteLine($"You died! Killed by { commandOrMonster}.");
                            Console.WriteLine($"Best room: {i + 1}");

                            return;
                        }
                        break;
                }
            }
            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
