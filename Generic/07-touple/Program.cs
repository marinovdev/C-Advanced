using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace _07_touple
{
    class Program
    {
        static void Main(string[] args)
        {
         
            var input1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var name = input1[0] + " " + input1[1];
            var address = input1[2];
            var input2 = Console.ReadLine().Split();
            var name2 = input2[0];
            var littres = int.Parse(input2[1]);
            var input3 = Console.ReadLine().Split();
            var intNum = int.Parse(input3[0]);
            var doubleNum = double.Parse(input3[1]);
            var personInfo = new MyTuple<string, string>(name, address);
            var beerInfo = new MyTuple<string, int>(name2, littres);
            var numbersInfo = new MyTuple<int, double>(intNum, doubleNum);
            Console.WriteLine($"{personInfo.ToString()}");
            Console.WriteLine($"{beerInfo}");
            Console.WriteLine($"{numbersInfo}");
        }
    }
}
