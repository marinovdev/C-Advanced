using System;
using System.Collections;
using System.Collections.Generic;

namespace _04_decimal_ro_binary_converter_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimalNumber = int.Parse(Console.ReadLine());
            Stack<string> binaryStack = new Stack<string>();
            string output = string.Empty;

            while (decimalNumber > 0)
            {
                if (decimalNumber == 0)
                {
                    output = "0";
                }
                else
                {
                    if (decimalNumber % 2 == 0)
                    {
                        binaryStack.Push("0");
                        decimalNumber = decimalNumber / 2;
                    }
                    else if (decimalNumber % 2 == 1)
                    {
                        binaryStack.Push("1");
                        decimalNumber = decimalNumber / 2;
                    }
                }
            }

            while(binaryStack.Count > 0)
            {
               output += binaryStack.Pop();
            }

            // result
            Console.WriteLine(output);
        }
    }
}
