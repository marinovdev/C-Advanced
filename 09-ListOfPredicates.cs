using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

class ListOfPredicates
{
    static void Main()
    {
        Process proc = Process.GetCurrentProcess();
        int n = int.Parse(Console.ReadLine());
        var sequence = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .Distinct()
            .ToList();
        List<int> output = new List<int>();

        for (int i = 1; i <= n; i++)
        {
            Predicate<List<int>> predicate = x => x.All(p => i % p == 0);
            if (predicate(sequence))
            {
                output.Add(i);
            }
        }
        sequence.Clear();
        Console.WriteLine($"{(decimal)proc.PrivateMemorySize64 / 1000000m:F2} MB");
        Console.WriteLine(string.Join(" ", output));
    }

}

