using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int discountedPokePower = pokePower;

            int count = 0;

            while (discountedPokePower >= distance)
            {
                discountedPokePower -= distance;
                count += 1;

                if (discountedPokePower == pokePower * 0.5 && exhaustionFactor > 0)
                {
                    discountedPokePower = discountedPokePower / exhaustionFactor;
                }         

            }
            Console.WriteLine(discountedPokePower);
            Console.WriteLine(count);
        }
    }
}
