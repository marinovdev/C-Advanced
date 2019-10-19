using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_generics
{
    class Box<T>
    {
        private static List<T> collection;

        public Box()
        {
            Collection = new List<T>();
        }
        public int Count
        {
            get
            {
                return Collection.Count();
            }

        }
        public static List<T> Collection
        {
            get { return collection; }
            set { collection = value; }
        }

        public void Add(T element)
        {
            Collection.Add(element);
        }

        public T Remove()
        {
            T var = Collection.ElementAt(0);
            Collection.RemoveAt(0);
            return var;
        }

    }
}
