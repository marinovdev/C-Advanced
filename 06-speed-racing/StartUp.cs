
namespace _06_speed_racing
{
using System;
using System.Collections.Generic;
    class StartUp
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var carsList = new CarsClass();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                string model = input[0];
                double fuelAmmount = double.Parse(input[1]);
                double fuelConsumption = double.Parse(input[2]);

                carsList.NewCar(new Car(model, fuelAmmount, fuelConsumption));
            }

            string execute = "";
            while((execute = Console.ReadLine()) != "End")
            {
                string[] arr = execute.Split();
                string carModel = arr[1];
                double ammountOfKm = double.Parse(arr[2]);
                carsList.Drive(carModel, ammountOfKm);
            }
            foreach (var car in carsList.Cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmmount:F2} {car.DistanceTravelled}");
            }
        }
    }
}
