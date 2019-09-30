using System;
using System.Linq;

namespace _03_count_upper_case_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> checker = x => x[0] == x.ToUpper()[0];
            string[] upperCaseWords = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Where(checker)
                .ToArray();

            foreach (var item in upperCaseWords)
            {
                Console.Write(item + " ");
            }
        }
    }
}
