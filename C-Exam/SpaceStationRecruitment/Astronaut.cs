
namespace SpaceStationRecruitment
{
using System;
using System.Collections.Generic;
using System.Text;
    class Astronaut
    {
        private string name;
        private int age;
        private string country;

        public Astronaut(string name, int age, string country)
        {
            this.name = name;
            this.age = age;
            this.country = country;
        }

        public override string ToString()
        {
            return $"Astronaut: {Name}, {Age} ({Country})";
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
