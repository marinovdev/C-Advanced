using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_generic_count_method_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var list = new Box<double>();
            for (int i = 0; i < n; i++)
            {
                list.Values.Add(double.Parse(Console.ReadLine()));
            }

            var comparisonValue = double.Parse(Console.ReadLine());
            Console.WriteLine(list.GraterValues(comparisonValue));

        }
    }

    class Box<T>
        where T : IComparable
    {
        private List<T> values;

        public Box()
        {
            this.Values = new List<T>();
        }
        public List<T> Values
        {
            get { return values; }
            set { values = value; }
        }

        public int GraterValues(T targtItem)
        {
            int counter = 0;
            foreach (var item in Values)
            {
                if (item.CompareTo(targtItem) > 0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
