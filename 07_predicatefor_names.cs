using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_predicatefor_names
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            var input = Console.ReadLine()
                 .Split()
                 .Where(x => x.Length <= length)
                 .ToList();
            input.ForEach(x => Console.WriteLine(x));
        }
    }
}
