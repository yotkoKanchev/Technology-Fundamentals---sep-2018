using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07TheatrePromotions
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfTheDay = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            int price = 0;
            switch (typeOfTheDay)
            {
                case "weekday":
                    if ((age >=0 && age <= 18) || (age > 64 && age <= 122))
                    {
                        price = 12;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 18;
                    }                    
                    else
                    {
                        price = 0;
                    }
                    break;
                case "weekend":
                    if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                    {
                        price = 15;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 20;
                    }
                    else
                    {
                        price = 0;
                    }
                    break;                    
                case "holiday":
                    if (age >= 0 && age <= 18)
                    {
                        price = 5;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 12;
                    }
                    else if ((age > 64 && age <= 122))
                    {
                        price = 10;
                    }
                    else
                    {
                        price = 0;
                    }
                    break;                    
            }
            if (price > 0)
            {
                Console.WriteLine($"{price}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
