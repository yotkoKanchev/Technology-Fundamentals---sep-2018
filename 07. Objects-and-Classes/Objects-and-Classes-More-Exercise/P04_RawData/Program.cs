using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_RawData
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

            string cargoCommand = Console.ReadLine();

            if (cargoCommand == "fragile")
            {
                foreach (var car in cars.Where(x=>x.CarCargo.CargoType == "fragile" && x.CarCargo.CargoWeight < 1000))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if (cargoCommand == "flamable")
            {
                foreach (var car in cars.Where(x=>x.CarCargo.CargoType == "flamable" && x.CarEngine.EnginePower > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }

        class Car
        {

            public Car(string[] tokens)
            {
                this.Model = tokens[0];
                this.CarEngine = new Engine(tokens);
                this.CarCargo = new Cargo(tokens);
            }
            public string Model { get; set; }
            public Engine CarEngine { get; set; }
            public Cargo CarCargo { get; set; }
        }

        class Engine
        {
            public Engine(string[] tokens)
            {
                this.EngineSpeed = int.Parse(tokens[1]);
                this.EnginePower = int.Parse(tokens[2]);
            }
            public int EngineSpeed { get; set; }
            public int EnginePower { get; set; }
        }

        class Cargo
        {
            public Cargo(string[] tokens)
            {
                this.CargoWeight = int.Parse(tokens[3]);
                this.CargoType = tokens[4];
            }
            public int CargoWeight { get; set; }
            public string CargoType { get; set; }
        }
    }
}
