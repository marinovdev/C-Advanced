using System;

namespace params_keyword
{
    class Program
    {
        static void Sum(string text, params int[] arr)
        {
            int sum = 0;
            foreach (var n in arr)
            {
                sum += n;
            }
            Console.WriteLine(text + sum);
        }
        static void Main(string[] args)
        {
            //params allows more easy way of parsing attributes to method
            Sum("Hello", 1, 2, 3, 4, 5);
            //prints hello 15
        }
    }
}
