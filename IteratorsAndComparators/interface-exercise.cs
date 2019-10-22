using System;

namespace interface_exercise
{
        public interface IMovable
        {
            void Move();
        }
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Move Car");
        }
    }
    public class Truck : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Move Truck");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var truck = new Truck();
            car.Move();
            truck.Move();
        }
    }
}
