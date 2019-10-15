
namespace _06_speed_racing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class CarsClass
    {
        private static List<Car> cars;

        public List<Car> Cars { get => cars; private set => cars = value; }
        private static Func<List<Car>, string, Car> getCar = (cars, model) =>
        cars.Where(car => car.Model == model).FirstOrDefault();

        public CarsClass()
        {
            Cars = new List<Car>();
        }
        public void NewCar(Car newCar)
        {
            if (Cars.Count == 0 || Cars.Any(car => car.Model != newCar.Model))
            {
                Cars.Add(newCar);
            }
        }

        public void Drive(string model, double ammountOfKm)
        {
            if (getCar(Cars, model).FuelAmmount - getCar(Cars, model)
                .FuelConsumptionPerKillometer * ammountOfKm >= 0 
                && Cars.Any(car => car.Model == model))
            {
                Cars.Where(car => car.Model == model)
                    .Select(car => car.FuelAmmount -=
                    getCar(Cars, model).FuelConsumptionPerKillometer * ammountOfKm)
                    .ToList();

                Cars.Where(car => car.Model == model)
                    .Select(car => car.DistanceTravelled 
                    += ammountOfKm)
                    .ToList();

            }
            else
            {
                System.Console.WriteLine($"Insufficient fuel for the drive");
            }
        }
    }

    public class Car
    {
        private string model;
        private double fuelAmmount;
        private double fuelConsumptionPerKillometer;
        private double distanceTravelled;

        public string Model { get => model; set => model = value; }
        public double FuelAmmount { get => fuelAmmount; set => fuelAmmount = value; }
        public double FuelConsumptionPerKillometer { get => fuelConsumptionPerKillometer; set => fuelConsumptionPerKillometer = value; }
        public double DistanceTravelled { get => distanceTravelled; set => distanceTravelled = value; }

        public Car(string model, double fuelAmmount, double fuelConsumption)
        {
            this.Model = model;
            this.FuelAmmount = fuelAmmount;
            this.FuelConsumptionPerKillometer = fuelConsumption;
            this.DistanceTravelled = 0;
        }

    }
}
