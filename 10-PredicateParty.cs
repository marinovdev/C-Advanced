using System;
using System.Collections.Generic;
using System.Linq;

class PredicateParty
{
    
    static void Main(string[] args)
    {
        Func<string, int, bool> lengthFunc = (name, length) => name.Length == length;
        Func<string, string, bool> startsWithFunc = (name, start) => name.StartsWith(start);
        Func<string, string, bool> endsWithFunc = (name, start) => name.EndsWith(start);
        var names = Console.ReadLine()
        .Split()
        .ToList();

        string command = Console.ReadLine();
        while(command != "Party!")
        {
            string[] commandInfo = command.Split();
            string action = commandInfo[0];
            string condition = commandInfo[1];
            string param = commandInfo[2];

            if(action == "Double")
            {
                if(condition == "Length")
                {
                    var temp = names.Where(x => lengthFunc(x, int.Parse(param))).ToList();
                    AddRange(names, temp);
                }
                else if (condition == "StartsWith")
                {
                    var temp = names.Where(x => startsWithFunc(x, param)).ToList();
                    AddRange(names, temp);
                }
                else if (condition == "EndsWith")
                {
                    var temp = names.Where(x => endsWithFunc(x, param)).ToList();
                    AddRange(names, temp);
                }
            }
           else if (action == "Remove")
            {
                if (condition == "Length")
                {
                    names = names.Where(x => !lengthFunc(x, int.Parse(param))).ToList();
                }
                else if (condition == "StartsWith")
                {
                   names = names.Where(x => !startsWithFunc(x, param)).ToList();
                }
                else if (condition == "EndsWith")
                {
                    names = names.Where(x => !endsWithFunc(x, param)).ToList();
                }
            }
            command = Console.ReadLine();
        }
        if(names.Count > 0)
        {
            Console.WriteLine(string.Join(", ", names) + " are going to the party!");
        }
        else
        {
            Console.WriteLine($"Nobody is going to the party!");
        }
    }

    private static void AddRange(List<string> names, List<string> temp)
    {
        foreach (var item in temp)
        {
            int index = names.IndexOf(item);
            names.Insert(index, item);
        }
    }
}

