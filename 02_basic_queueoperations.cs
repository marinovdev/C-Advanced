using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_basic_queueoperations
{
    class BasicOperations
    {
        static void Main()
        {
            Queue<int> numbersStack = new Queue<int>();
            int[] input = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                 .ToArray();
            int[] numbersInput = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToArray();
            //Push N elements in the stack
            for (int i = 0; i < input[0]; i++)
            {
                numbersStack.Enqueue(numbersInput[i]);
            }
            // Pop S elements from the stack
            numbersStack.Reverse();
            for (int i = 0; i < input[1]; i++)
            {
                numbersStack.Dequeue();
            }
            // Check if X is present in the stack
            if (numbersStack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if (numbersStack.Contains(input[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine($"{numbersStack.Min()}");
            }
        }
    }
}
