using System;

namespace _02_knight_of_honor
{
    class Knights
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Action<string[]> print = Print;
            print(input);
        }

        static void Print(string[] input)
        {
            foreach (var name in input)
            {
                Console.WriteLine($"Sir {name}");
            }
        }
    }
}
