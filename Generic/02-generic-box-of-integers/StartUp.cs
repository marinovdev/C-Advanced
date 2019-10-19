using System;
using System.Collections.Generic;

namespace _01_generic_box_of_string
{
    class Program
    {
        public static List<int> list = new List<int>();
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = int.Parse(Console.ReadLine());
                list.Add(input);
            }
            for (int i = 0; i < list.Count; i++)
            {
                var read = list[i];
                var box = new Box<int>(read);
                box.ToString();
            }
        }
    }

    class Box<T>
        where T : struct
    {
        public T Value { get; set; }

        public Box(T number)
        {
            this.Value = number;
        }

        public void ToString()
        {
            Console.WriteLine($"{Value.GetType()}: {Value}");
        }
    }
}
