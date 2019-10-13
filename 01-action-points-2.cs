using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_action_point
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> print = items =>
            Console.WriteLine(string.Join(Environment.NewLine, items));

            string[] input = Console.ReadLine()
                .Split();
            print(input);
        }
    }
}
