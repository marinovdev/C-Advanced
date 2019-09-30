using System;
using System.Linq;
using System.Collections.Generic;

namespace _05_filter_by_age
{
 
    class Program
    {
        public class People
        {
            string Name { get; set; }
            int Age { get; set; }

        }

        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            List<KeyValuePair<string, int>> listOfPeople = new List<KeyValuePair<string, int>>();
            //loop and add each pair to list of people
            for (int i = 0; i < peopleCount; i++)
            {
                string[] person = Console.ReadLine()
                    .Split(", ");

                listOfPeople.Add
                    ( new KeyValuePair<string, int>(person[0], int.Parse(person[1])));
            }
            string filter = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string[] printPattern = Console.ReadLine()
                .Split(' ');
            listOfPeople
                .Where(p => filter == "younger" ? p.Value < age : p.Value >= age)
                .ToList()
                .ForEach(p => Printer(p, printPattern));

        }

        static void Printer(KeyValuePair<string, int> person, string[] printPattern)
        {
            if (printPattern.Length == 2)
            {
                Console.WriteLine(printPattern[0] == "name" ? $"{person.Key} - {person.Value}"
                    : $"{person.Value} - {person.Key}");
            }
            else
            {
                Console.WriteLine($"{person.Key}");
            }
        }
    }
}
