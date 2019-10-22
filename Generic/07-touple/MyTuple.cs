using System;
using System.Collections.Generic;
using System.Text;

namespace _07_touple
{
    class MyTuple<T, TT>
    {
        private T item1;
        private TT item2;

        public MyTuple(T item1, TT item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }

        public override string ToString()
        {
            return $"{this.Item1} -> {this.Item2}";
        }

        public TT Item2
        {
            get { return item2; }
            set { item2 = value; }
        }

        public T Item1
        {
            get { return item1; }
            set { item1 = value; }
        }

    }
}
