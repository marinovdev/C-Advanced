using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Reverse_and_exclude
{
    class Reverse
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int n = int.Parse(Console.ReadLine());
            input.Reverse();
            Predicate<int> predicate = x => x % n == 0;
            Func<List<int>, Predicate<int>, string> exclude = Exclude;
            Console.WriteLine(exclude(input, predicate));

        }
        static string Exclude(List<int> input, Predicate<int> predicate)
        {
            
            input.RemoveAll(x => predicate(x));
            return string.Join(" ", input);
        }
    }
}
