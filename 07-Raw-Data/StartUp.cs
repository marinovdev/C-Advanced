using System;
using System.Collections.Generic;
using System.Linq;
namespace _07_Raw_Data
{
    class StartUp
    {
        public static List<Car> cars = new List<Car>();
        static void Main(string[] args)
        {
            Func<List<Car>, int, List<Car>> groupByPressure =
                (cars, tirePressure) =>
                cars.Where(
                    car =>
                    (car.Cargo.CargoType == "fragile")
                    )
                .Where(
                    car =>
                    car.Tire.Any(tire => tire.TirePressure < tirePressure))
                .ToList();

            Func<List<Car>, int, List<Car>> groupByEnginePower =
                (cars, enginePower) =>
                cars.Where(
                    car =>
                    (car.Cargo.CargoType == "flamable")
                    )
                .Where(
                    car =>
                    car.Engine.EnginePower > enginePower
                    )
                .ToList();

            for (int i = int.Parse(Console.ReadLine()); i > 0; i--)
            {
                var input = Console.ReadLine().Split();
                var newCar = ConvertStringToCar(input);
                cars.Add(newCar);
            }
            string criteria = Console.ReadLine();
            if (criteria == "fragile")
            {
                foreach (var car in groupByPressure(cars, 1))
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
            else if (criteria == "flamable")
            {
                foreach (var car in groupByEnginePower(cars, 250))
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
        }

        public static Car ConvertStringToCar(string[] input)
        {
            string model = input[0];
            int engineSpeed = int.Parse(input[1]);
            int enginePower = int.Parse(input[2]);
            int cargoWeight = int.Parse(input[3]);
            string cargoType = input[4];
            double tire1Pressure = double.Parse(input[5]);
            int tire1Age = int.Parse(input[6]);
            double tire2Pressure = double.Parse(input[7]);
            int tire2Age = int.Parse(input[8]);
            double tire3Pressure = double.Parse(input[9]);
            int tire3Age = int.Parse(input[10]);
            double tire4Pressure = double.Parse(input[11]);
            int tire4Age = int.Parse(input[12]);
            var engine = new Engine(engineSpeed, enginePower);
            var cargo = new Cargo(cargoWeight, cargoType);
            var tires = new Tire[] { new Tire(tire1Pressure, tire1Age),
                new Tire(tire2Pressure, tire2Age),
                new Tire(tire3Pressure, tire3Age),
                new Tire(tire4Pressure, tire4Age) };

            return new Car(model, engine, cargo, tires);
        }
    }
}
