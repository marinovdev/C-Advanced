using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_find_even_or_odds
{
    class EvenOrOdds
    {
        public static List<int> numbers = new List<int>();
        static void Main(string[] args)
        {
            var boundaries = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();
            for (int  i = boundaries[0];  i <= boundaries[1];  i++)
            {
                numbers.Add(i);
            }
            string criteria = Console.ReadLine().ToLower();
            Func<int, bool> predicate = x => x % 2 == 0;
            if (criteria == "even")
            {
                numbers = numbers.Where(predicate).ToList();
            }
            else if(criteria == "odd")
            {
                numbers = numbers.Where(x => !predicate(x)).ToList();
            }

                Console.WriteLine(string.Join(" ", numbers));

        }
  
    }
}
