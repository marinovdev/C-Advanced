using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumeratorLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // for loop implements the IEnumerator Interface
            IEnumerable<int> list = new List<int>() { 1, 2, 3, 4, 5, };
            IEnumerator<int> enumerator = list.GetEnumerator();

            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}
