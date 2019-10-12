using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_custom_comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            Func<List<int>, List<int>> even = OrderEven;
            var output = even(input);
            Func<List<int>, List<int>> odd = OrderOdd;
            output = output.Concat(odd(input)).ToList();
            output.ForEach(x => Console.Write(x + " "));
        }

        static List<int> OrderEven(List<int> input)
        {
            var newList = input.Where(x => x % 2 == 0).OrderBy(x => x).ToList();
            return newList;
        }
        static List<int> OrderOdd(List<int> input)
        {
            var newList = input.Where(x => x % 2 == 1 || x % 2 == -1).OrderBy(x => x).ToList();
            return newList;
        }
    }
}
