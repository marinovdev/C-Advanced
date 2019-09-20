using System;
using System.Collections.Generic;

namespace _05_matching_brackets_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stackOpeningBrackets = new Stack<int>();
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] == '(')
                {
                    stackOpeningBrackets.Push(i);
                }
                if(input[i] == ')')
                {

                    for (int y = stackOpeningBrackets.Pop(); y <= i; y++)
                    {
                        Console.Write(input[y]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
