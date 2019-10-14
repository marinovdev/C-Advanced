using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class  Person 
    {
        private string name;
        private int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

    }
    class Family
    {
        private static List<Person> familyMembers = new List<Person>();

        public List<Person> FamilyMembers { get => familyMembers; set => familyMembers = value; }

        public void AddMember(Person person)
        {
            this.FamilyMembers.Add(person);
        }
        
        public List<Person> GetOldestMember()
        {
           
            //var oldestPerson = familyMembers.Aggregate((x, y) => x.Age > y.Age ? x : y);
            var oldestPerson = familyMembers.Where(x => x.Age > 30).OrderBy(a => a.Name).ToList();
            return oldestPerson;
        }
    }
    public class StartUp
    {
        static void Main(string[] args)
        {
            var familyMembers = new Family();
            int n = int.Parse(Console.ReadLine());
            while(n > 0)
            {
                var input = Console.ReadLine()
                    .Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                var person = new Person(name, age);
                familyMembers.AddMember(person);
                --n;
            }
            foreach (var person in familyMembers.GetOldestMember())
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
