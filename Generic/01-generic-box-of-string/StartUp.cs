using System;
using System.Collections.Generic;

namespace _01_generic_box_of_string
{
    class Program
    {
        public static List<string> list = new List<string>();
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                list.Add(input);
            }
            for (int i = 0; i < list.Count; i++)
            {
                var read = list[i];
                var box = new Box<string>(read);
                box.ToString();
            }
        }
    }

    class Box<T>
        where T: class
    {
        public T Value { get; set; }

        public Box(T text)
        {
            this.Value = text;
        }

        public void ToString()
        {
            Console.WriteLine($"{Value.GetType()}: {Value}");
        }
    }
}
