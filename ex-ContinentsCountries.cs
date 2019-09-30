using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


class ContinentsCountries
{
    static void Main()
    {
        var continents = new Dictionary<string, Dictionary<string, List<string>>>();
        for (int i = int.Parse(Console.ReadLine()); i > 0; i--)
        {
            string[] input = Console.ReadLine()
                .Split();
            string continent = input[0];
            string country = input[1];
            string city = input[2];
            if(!continents.ContainsKey(continent))
            {
                continents.Add(continent, new Dictionary<string, List<string>>());
            }
            if (!continents[continent].ContainsKey(country))
            {
                continents[continent].Add(country, new List<string>());
            }
            if(!continents[continent][country].Contains(city))
            {
                continents[continent][country].Add(city);
            }
        }
        foreach (var continent in continents)
        {
            Console.WriteLine($"{continent.Key}");
            foreach (var country in continents[continent.Key])
            {
                Console.WriteLine($"{country.Key} -> {string.Join(" ", country.Value)}");
            }
        }
    }
}

