using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_action_point
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split()
                .ToList();
            input.ForEach(x => Console.WriteLine(x));
        }
    }
}
