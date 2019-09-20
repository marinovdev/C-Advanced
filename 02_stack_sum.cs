using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_stack_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stackNumbers = new Stack<int>();
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            foreach (var item in numbers)
            {
                stackNumbers.Push(item);
            }
            string command = string.Empty;
            while((command = Console.ReadLine().ToLower())  != "end")
            {
                string[] order = command.Split();
                switch(order[0])
                {
                    case "add":
                        stackNumbers.Push(int.Parse(order[1]));
                        stackNumbers.Push(int.Parse(order[2]));
                        break;
                    case "remove":
                        int count = int.Parse(order[1]);

                        if(count < stackNumbers.Count)
                        {
                            for (int i = count; i > 0; i--)
                            {
                                stackNumbers.Pop();
                            }
                        }
                        break;
                }
            }
            int sumInStack = 0;
            for (int i = stackNumbers.Count - 1; i >= 0; i--)
            {
                sumInStack += stackNumbers.Pop();
            }
            Console.WriteLine("Sum: " + sumInStack);
        }
    }
}
