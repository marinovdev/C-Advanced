using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03_simple_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Stack<string> stackNumbers = new Stack<string>();
            Stack<string> reversed = new Stack<string>();
            foreach (var item in numbers)
            {
                stackNumbers.Push(item);
            }
            while (stackNumbers.Count > 0)
            {
                reversed.Push(stackNumbers.Pop());
            }
            int currentNumber = int.Parse(reversed.Pop());
            while(reversed.Count > 0)
            {
                string operation = reversed.Pop();
                if(operation == "+")
                {
                    currentNumber += int.Parse(reversed.Pop());
                }
                else if(operation == "-")
                {
                    currentNumber -= int.Parse(reversed.Pop());
                }
            }
            Console.WriteLine(currentNumber);
        }
    }
}
