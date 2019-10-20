using System;
using System.Collections.Generic;

namespace extension_method_example
{
    class Program
    {
        static void Main(string[] args)
        {
            var box = new Box<string>();
            box.Values = "Random text";
            Console.WriteLine(box.ToString());
        }
    }

    class Box<T>
    {
        private T values;

        public Box()
        {
            this.values = default(T);
        }

        public T Values
        {
            get { return values; }
            set { values = value; }
        }

        public override string ToString()
        {
            //extension methods are attatched as suffix to a given var :
            return $"{Values.GetType()}: {Values}".AddNumbers();
        }

    }
}
