using System;
using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
        char[] charArray = new char[2] { 'a', '9' };
        foreach (var ch in charArray)
        {
            int number = 0;
            if(int.TryParse(ch.ToString(), out number))
                Console.WriteLine(number);
        }
       
        }
    
    }




