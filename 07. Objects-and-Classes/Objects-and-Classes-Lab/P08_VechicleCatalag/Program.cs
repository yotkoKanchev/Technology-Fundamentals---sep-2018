using System;
using System.Collections.Generic;
using System.Linq;

namespace P08._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] tokens = inputLine.Split("/");
                
                if (tokens[0] == "Car")
                {
                    Car car = new Car()
                    {
                        Brand = tokens[1],
                        Model = tokens[2],
                        HorsePower = int.Parse(tokens[3])                       
                    };
                    cars.Add(car);
                }
                else if (tokens[0] == "Truck")
                {
                    Truck truck = new Truck()
                    {
                        Brand = tokens[1],
                        Model = tokens[2],
                        Weight = int.Parse(tokens[3])
                    };
                    trucks.Add(truck);
                }

                inputLine = Console.ReadLine();                
            }

            Catalog catalog = new Catalog()
            {
                CarVechicle = cars,
                TruckVechicle = trucks
            };

            Console.WriteLine("Cars:");
            foreach (var car in catalog.CarVechicle.OrderBy(x=>x.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            Console.WriteLine("Trucks:");
            foreach (var truck in catalog.TruckVechicle.OrderBy(x=>x.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }

        class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }
        }

        class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int HorsePower { get; set; }
        }

        class Catalog
        {
            public List<Truck> TruckVechicle { get; set; }
            public List<Car> CarVechicle { get; set; }
        }
    }
}
