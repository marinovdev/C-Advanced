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
                .ToArray();
            Func<int, int, int> customComparator = (a, b) =>
            {
                if (a % 2 == 0 && b % 2 == 0)
                {
                    if (a < b)
                    {
                        return -1;
                    }
                    if (a > b)
                    {
                        return 1;
                    }
                    return 0;
                }
                if (a % 2 != 0 && b % 2 != 0)
                {
                    if (a > b)
                    {
                        return 1;
                    }
                    if (a < b)
                    {
                        return -1;
                    }
                    return 0;
                }
                if(a % 2 == 0)
                {
                    return -1;
                }
                if (a % 2 != 0)
                {
                    return 1;
                }
                return 0;
            };
            Array.Sort(input, new Comparison<int>(customComparator));
            Console.WriteLine(string.Join(" ", input));
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
