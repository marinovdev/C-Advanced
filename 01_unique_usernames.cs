using System;
using System.Collections.Generic;

namespace _01_unique_usernames
{
    class Usernames
    {
        static void Main(string[] args)
        {
            HashSet<string> usernames = new HashSet<string>();
            for (int i = int.Parse(Console.ReadLine()); i > 0; i--)
            {
                usernames.Add(Console.ReadLine());
            }
            foreach (var item in usernames)
            {
                Console.WriteLine(item);
            }
        }
    }
}
