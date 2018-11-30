using System;
using System.Collections.Generic;

namespace P03_SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                Car car = new Car(tokens);
                cars.Add(car);
            }

            string inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                string[] askedData = inputLine.Split();

                cars.Find(x => x.Model == askedData[1]).FindCarCanMoveOrNot(double.Parse(askedData[2]));

                inputLine = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TraveledDistance}");
            }
        }

        class Car
        {
            public string Model { get; set; }
            public double FuelAmount { get; set; }
            public double FuelConsumption { get; set; }
            public double TraveledDistance { get; set; }

            public Car(string [] tokens)
            {
                this.Model = tokens[0];
                this.FuelAmount = double.Parse(tokens[1]);
                this.FuelConsumption = double.Parse(tokens[2]);
            }

            public void FindCarCanMoveOrNot(double distance)
            {
                double neededFuel = this.FuelConsumption * distance;

                if (this.FuelAmount >= neededFuel)
                {
                    this.TraveledDistance += distance;
                    this.FuelAmount -= neededFuel;
                }
                else
                {
                    Console.WriteLine($"Insufficient fuel for the drive");
                }
            }
        }
    }
}
