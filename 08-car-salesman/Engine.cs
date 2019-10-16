
namespace _08_car_salesman
{
using System;
using System.Collections.Generic;
using System.Text;
    class Engine
    {

        private string model;
        private int power;
        private int displacement;
        private string efficiency;

        public Engine()
        {

        }
        public Engine(string model, int power)
        {
            Power = power;
            Model = model;
        }
        public Engine(string model, int power, string efficiency)
        {
            Efficiency = efficiency;
            Power = power;
            Model = model;
        }
        public Engine(string model, int power, int dispalacement)
        {
            Efficiency = efficiency;
            Dispalacement = dispalacement;
            Power = power;
            Model = model;
        }

        public Engine(string model, int power, int dispalacement, string efficiency)
        {
            Efficiency = efficiency;
            Dispalacement = dispalacement;
            Power = power;
            Model = model;
        }

        public string Efficiency
        {
            get { return efficiency; }
            set { efficiency = value; }
        }

        public int Dispalacement
        {
            get { return displacement; }
            set { displacement = value; }
        }

        public int Power
        {
            get { return power; }
            set { power = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

    }
}
