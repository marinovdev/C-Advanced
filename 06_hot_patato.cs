using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_hot_patato
{
    class Program
    {
        static void Main()
        {
            Queue<string> childrenNames = new Queue<string>();
            List<string> childrenInput = Console.ReadLine()
                .Split()
                .ToList();
            int nSkip = int.Parse(Console.ReadLine());

            foreach (var item in childrenInput)
            {
                childrenNames.Enqueue(item);
            }
            string current = string.Empty;
            while (childrenNames.Count > 1)
            {
                for (int i = 1; i <= nSkip; i++)
                {
                    if(i == nSkip)
                    {
                        Console.WriteLine($"Removed {childrenNames.Dequeue()}");
                    }
                    else
                    {
                        current = childrenNames.Dequeue();
                        childrenNames.Enqueue(current);
                    }
                }
            }
            Console.WriteLine($"Last is {childrenNames.Dequeue()}");

        }
    }
}
