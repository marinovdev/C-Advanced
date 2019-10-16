
namespace _08_car_salesman
{
using System;
using System.Collections.Generic;
using System.Text;
    class Car
    {
        private string model;
        private Engine engine;
        private int Weigth;
        private string color;

        public Car() { }

        public Car(string model, Engine engine, string color)
        {
            Engine = engine;
            Model = model;
            Color = color;
        }
        public Car( string model, Engine engine)
        {
            Engine = engine;
            Model = model;
        }
        public Car(string model, Engine engine, int weight)
        {
            Engine = engine;
            Model = model;
            Weight = weight;
        }
        public Car(string model, Engine engine, int weight, string color)
        {
            Color = color;
            Weight = weight;
            Engine = engine;
            Model = model;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Weight
        {
            get { return Weigth; }
            set { Weigth = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

    }
}
