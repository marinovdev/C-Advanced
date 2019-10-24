using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_sokcs
{
    class Program
    {
        public static List<int> pairs = new List<int>();
        static void Main(string[] args)
        {
            var leftEntry = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rightEntry = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var left = new Stack<int>(leftEntry);
            var right = new Queue<int>(rightEntry);
            // if the left sock is bigger than the right sock and if it is – you have to create a pair. 
            // If you have a pair, remove both the left and the right socks from their collections. 

            //If the right sock value is bigger – remove the left one and check the next one. 
            //If their values are equal – remove the right sock and increment the value of the left one with 1.

            while(left.Count > 0 && right.Count > 0)
            {
                var leftValue = left.Peek();
                var rightValue = right.Peek();
                //9 5 4 7 8 5 2 6 9
                //1 4 5 7 9 6 3 5 4 7
                // 10 10 15 16
                if (leftValue > rightValue)
                {
                    pairs.Add(left.Pop() + right.Dequeue());
                }
                else if(rightValue == leftValue)
                {
                    right.Dequeue();
                    var tempList = left.ToList();
                    tempList[0]++;
                    tempList.Reverse();
                    left = new Stack<int>(tempList);
                    //left.Where(s => s == leftValue).Select(s => s++); // <========
                }
                else if(leftValue < rightValue)
                {
                    left.Pop();
                }
            }
            if(pairs.Count > 0)
            {
                Console.WriteLine(pairs.OrderByDescending(x => x).First()); ;
                Console.WriteLine(string.Join(" ", pairs));
            }

        }
    }
}
