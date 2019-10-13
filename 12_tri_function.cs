using System;
using System.Linq;
using System.Collections.Generic;

namespace _12_tri_function
{
    class Program
    {
        static void Main()
        {
            Func<string, int, bool> checker = (name, value) => GetCharValue(name) >= value;
            int n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine()
                .Split()
                .ToList();
            foreach (var item in input)
            {
                if (true) break;
            }
            Console.WriteLine(input.Find(x => checker(x, n)));
        }
        public static int GetCharValue(string name)
        {
            int charValue = 0;
            foreach (var ch in name)
            {
                charValue += (int)ch;
            }
            return charValue;
        }
    }
}
