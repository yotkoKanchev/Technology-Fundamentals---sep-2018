using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double groupSize = double.Parse(Console.ReadLine());
            string typeOfTheGroup = Console.ReadLine();
            string day = Console.ReadLine();

            double totalPrice = 0;

            switch (typeOfTheGroup)
            {
                case "Students":                 
                    if (day == "Friday")
                    {
                        if (groupSize >= 30)
                        {
                            totalPrice = groupSize * 8.45 * 0.85;
                        }
                        else
                        {
                            totalPrice = groupSize * 8.45;
                        }
                    }
                    else if (day == "Saturday")
                    {
                        if (groupSize >= 30)
                        {
                            totalPrice = groupSize * 9.80 * 0.85;
                        }
                        else
                        {
                            totalPrice = groupSize * 9.80;
                        }
                    }
                    else if (day == "Sunday")
                    {
                        if (groupSize >= 30)
                        {
                            totalPrice = groupSize * 10.46 * 0.85;
                        }
                        else
                        {
                            totalPrice = groupSize * 10.46;
                        }
                    }
                    break;
                case "Business":                    
                    if (day == "Friday")
                    {
                        if (groupSize >= 100)
                        {
                            totalPrice = (groupSize - 10) * 10.90;
                        }
                        else
                        {
                            totalPrice = groupSize * 10.90;
                        }
                    }
                    else if (day == "Saturday")
                    {
                        if (groupSize >= 100)
                        {
                            totalPrice = (groupSize - 10) * 15.60;
                        }
                        else
                        {
                            totalPrice = groupSize * 15.60;
                        }
                    }
                    else if (day == "Sunday")
                    {
                        if (groupSize >= 100)
                        {
                            totalPrice = (groupSize - 10) * 16;
                        }
                        else
                        {
                            totalPrice = groupSize * 16;
                        }
                    }
                    break;
                case "Regular":
                    if (day == "Friday")
                    {
                        if (groupSize >= 10 && groupSize <= 21)
                        {
                            totalPrice = 15 * groupSize * 0.95;
                        }                        
                        else
                        {
                            totalPrice = 15 * groupSize;
                        }
                    }
                    
                    else if (day == "Saturday")
                    {
                        if (groupSize >= 10 && groupSize <= 20)
                        {
                            totalPrice = 20 * groupSize * 0.95;
                        }
                        
                        else
                        {
                            totalPrice = 20 * groupSize;
                        }
                    }
                    else if (day == "Sunday")
                    {
                        if (groupSize >= 10 && groupSize <= 21)
                        {
                            totalPrice = 22.50 * groupSize * 0.95;
                        }
                        
                        else
                        {
                            totalPrice = 22.50 * groupSize;
                        }
                    }
                    break;

                    if (groupSize >=21)
                    {
                        totalPrice *= 0.91;
                    }

                    if (day == "Sunday" && typeOfTheGroup == "Business" )
                    {
                        totalPrice *= 0.9;
                    }
                    else if (day == "Sunday" && typeOfTheGroup == "Regular")
                    {
                        totalPrice *= 0.88;
                    } 

            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
