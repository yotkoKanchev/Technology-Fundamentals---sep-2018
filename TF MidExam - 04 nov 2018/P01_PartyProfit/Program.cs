using System;

namespace P01_PartyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int partySize = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int companions = partySize;
            int coins = 0;

            for (int i = 1; i <= days; i++)
            {               

                if (i % 10 == 0)
                {
                    companions -= 2;
                }

                if (i % 15 == 0)
                {
                    companions += 5;
                }

                coins = coins + 50 - (companions * 2);

                if (i % 3 == 0)
                {
                    coins = coins - (companions * 3);
                }
                if (i % 5 == 0)
                {
                    coins = coins + (companions * 20);
                    if (i % 3 == 0)
                    {
                        coins = coins - (companions * 2);
                    }
                }                
            }
            Console.WriteLine($"{companions} companions received {Math.Floor((double)coins/(double)companions)} coins each.");
        }
    }
}
