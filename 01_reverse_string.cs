using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01_reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> reversed = new Stack<string>();
            string text = Console.ReadLine();
                
            MatchCollection matches = Regex.Matches(text, @".");
            foreach (Match item in matches)
            {
                reversed.Push(Convert.ToString(item));
            }

            for (int i = reversed.Count; i > 0; i--)
            {
                Console.Write(reversed.Pop());
            }
        }
    }
}
