using System;
using System.Numerics;

namespace _08SnowBalls
{
    class Program
    {
        static void Main()
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());

            int snowballSnow = 0;
            int snowballTime = 0;
            double snowballQuality = 0;

            BigInteger snowballValue = 0;
            for (int i = 1; i <= numberOfSnowballs; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                BigInteger newSnowballValue = BigInteger.Pow((snow / time), quality);
                if (newSnowballValue >= snowballValue)
                {
                    snowballValue = newSnowballValue;
                    snowballSnow = snow;
                    snowballTime = time;
                    snowballQuality = quality;
                }
            }
            Console.WriteLine($"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})");
        }
    }
}
