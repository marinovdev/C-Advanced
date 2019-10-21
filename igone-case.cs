using System;
using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string text = "Preslav";
            string text2 = "preslav";
            //comparing string not case sensitive
            StringComparison comparison = StringComparison.CurrentCultureIgnoreCase;
            Console.WriteLine(text.Equals(text2, comparison));
        }
    }
