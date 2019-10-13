using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


class startsWithFilterFunc
{

    static void Main()
    {
        List<string> startsWith = new List<string> { "P", "M" };
        List<string> names = new List<string> { "Petar", "Nikolay", "Iva", "Martin" };
        Func<string, List<string>, bool> startsWithFunc = (name, condition) =>
        condition.All(c => !name.StartsWith(c));
        Console.WriteLine(string.Join(", ", names.Where(x => startsWithFunc(x, startsWith))));
    }
}

