using System;
using System.Collections.Generic;
using System.Text;

namespace treeuple
{
    class Treeuple<T, TT, TTT>
    {
        private T item1;
        private TT item2;
        private TTT item3;


        public Treeuple(T item1, TT item2, TTT item3)
        {
            this.Item1 = item1;
            this.Item2 = item2;
            this.Item3 = item3;
        }

        public override string ToString()
        {
            return $"{this.Item1} -> {this.Item2} -> {this.Item3}";
        }
        public TTT Item3
        {
            get { return item3; }
            set { item3 = value; }
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
