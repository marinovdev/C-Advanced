using System;
using System.Linq;
using System.Collections.Generic;

namespace _12_tri_function-2
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int, bool> checker = (name, value) => GetCharValue(name) >= value;
            int n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine()
                .Split()
                .ToArray();
            Func<string[], Func<string, int, bool>, string> getName = (collection, check) =>
            collection.FirstOrDefault(x => checker(x, n));

            Console.WriteLine(getName(input,checker));
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
