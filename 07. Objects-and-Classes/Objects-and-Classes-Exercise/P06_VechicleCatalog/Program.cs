using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vechicle> vechicles = new List<Vechicle>();

            string inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                string[] vechicleParameters = inputLine.Split();

                Vechicle vechicle = new Vechicle(vechicleParameters);

                if (vechicle.TypeOfVechicle.ToLower() == "car")
                {
                    vechicle.TypeOfVechicle = "Car";
                }
                else if (vechicle.TypeOfVechicle.ToLower() == "truck")
                {
                    vechicle.TypeOfVechicle = "Truck";
                }
                vechicles.Add(vechicle);

                inputLine = Console.ReadLine();
            }

            string askedBrand = Console.ReadLine();

            while (askedBrand != "Close the Catalogue")
            {
                foreach (var vechicle in vechicles)
                {
                    if (askedBrand == vechicle.ModelOfVechicle)
                    {
                        Console.WriteLine($"Type: {vechicle.TypeOfVechicle}");
                        Console.WriteLine($"Model: {vechicle.ModelOfVechicle}");
                        Console.WriteLine($"Color: {vechicle.ColorOfVechicle}");
                        Console.WriteLine($"Horsepower: {vechicle.Horsepower}");
                    }
                }
                askedBrand = Console.ReadLine();
            }

            int carsCounter = vechicles.Where(x => x.TypeOfVechicle == "Car").Count();
            int truckCounter = vechicles.Where(x => x.TypeOfVechicle == "Truck").Count();

            if (carsCounter > 0)
            {
                foreach (var car in vechicles.Where(x => x.TypeOfVechicle == "Car"))
                {
                    Console.WriteLine($"Cars have average horsepower of: {vechicles.Where(x => x.TypeOfVechicle == "Car").Select(x => x.Horsepower).Average():f2}.");
                    break;
                }
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }

            if (truckCounter > 0)
            {
                foreach (var truck in vechicles.Where(x => x.TypeOfVechicle == "Truck"))
                {
                    Console.WriteLine($"Trucks have average horsepower of: {vechicles.Where(x => x.TypeOfVechicle == "Truck").Select(x => x.Horsepower).Average():f2}.");
                    break;
                }
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }         
            
        }

        class Vechicle
        {
            public Vechicle(string[] vechiclesParameters)
            {
                this.TypeOfVechicle = vechiclesParameters[0];
                this.ModelOfVechicle = vechiclesParameters[1];
                this.ColorOfVechicle = vechiclesParameters[2];
                this.Horsepower = int.Parse(vechiclesParameters[3]);
            }
            public string TypeOfVechicle { get; set; }
            public string ModelOfVechicle { get; set; }
            public string ColorOfVechicle { get; set; }
            public int Horsepower { get; set; }
        }
    }
}
