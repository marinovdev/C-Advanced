
namespace _08_car_salesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static List<Engine> engines = new List<Engine>();
        public static List<Car> cars = new List<Car>();
        static void Main(string[] args)
        {
            var engine = new Engine();
            var car = new Car();
            for (int i = int.Parse(Console.ReadLine()); i > 0; i--)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                // "{model} {power} {displacement} {efficiency}"
                string model = input[0];
                int power = int.Parse(input[1]);
                int displacement = 0;
                string efficiency = "";
                engine = new Engine(model, power);
                if (input.Length >= 3)
                {
                    if (int.TryParse(input[2], out displacement))
                    {
                        displacement = int.Parse(input[2]);
                        engine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        efficiency = input[2];
                        engine = new Engine(model, power, efficiency);
                    }
                }
                if (input.Length == 4)
                {
                    efficiency = input[3];
                    engine = new Engine(model, power, displacement, efficiency);
                }
                engines.Add(engine);
            }
            for (int m = int.Parse(Console.ReadLine()); m > 0; m--)
            {
                var input = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                engine = engines.FirstOrDefault(eng => eng.Model == input[1]);
                int weigth = 0;
                string color = "";
                car = new Car(model, engine);
                if (input.Length >= 3)
                {
                    if (int.TryParse(input[2], out weigth))
                    {
                        weigth = int.Parse(input[2]);
                        car = new Car(model, engine, weigth);
                    }
                    else
                    {
                        color = input[2];
                        car = new Car(model, engine, color);
                    }
                }
                if (input.Length == 4)
                {
                    color = input[3];
                    car = new Car(model, engine, weigth, color);
                }
                cars.Add(car);
            }
            foreach (var vehicle in cars)
            {
                Console.WriteLine(vehicle.Model + ":");
                Console.WriteLine($"  {vehicle.Engine.Model}:");
                Console.WriteLine($"    Power: {vehicle.Engine.Power}");
                Console.WriteLine("    Displacement: " + (vehicle.Engine.Dispalacement != 0 ? $"{vehicle.Engine.Dispalacement}" : "n/a")); // <===
                Console.WriteLine("    Efficiency: " + (vehicle.Engine.Efficiency != null ? $"{vehicle.Engine.Efficiency}" : "n/a"));
                Console.WriteLine("  Weight: " + (vehicle.Weight != 0 ? $"{vehicle.Weight}" : "n/a"));
                Console.WriteLine("  Color: " + (vehicle.Color != null ? $"{vehicle.Color}" : "n/a"));
            }
        }
    }
}
