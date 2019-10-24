using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01club_party
{
    class Program
    {
        public static Dictionary<string, List<int>> dic = new Dictionary<string, List<int>>();
        static void Main(string[] args)
        {
            var capacity = int.Parse(Console.ReadLine());
            var lineEntry = Console.ReadLine().Split().ToArray();
            var line = new Stack<string>(lineEntry);
            int currentIndex = 0;
            while (line.Count > 0)
            {
                var currentElement = line.Peek();
                var number = 0;
                var elementNumber = int.TryParse(currentElement, out number);

                //50
                //15 a 40 30 20 c 15 10 b 
                //    b -> 10, 15, 20
                //    c-> 30

                if (elementNumber && dic.Count > 0)
                {
                Begin:
                    if (dic.Count > currentIndex && dic.ElementAt(currentIndex).Value.Sum() + number <= capacity)
                    {
                        dic.ElementAt(currentIndex).Value.Add(number);
                    }
                    else if (true)
                    {
                        PrintHall(currentIndex);
                        if (line.Count > 0 && !(currentIndex + 1 >= dic.Count))
                        {
                            currentIndex++;
                            goto Begin;
                        }
                    }
                }
                else if (!elementNumber)
                {
                    dic.Add(currentElement, new List<int>());

                }
                line.Pop();
            }
        }

        public static void PrintHall(int currentIndex)
        {
            Console.WriteLine($"{dic.ElementAt(currentIndex).Key} ->" +
                $" {string.Join(", ", dic.ElementAt(currentIndex).Value)}");
        }
    }
}
