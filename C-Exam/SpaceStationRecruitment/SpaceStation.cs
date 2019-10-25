
namespace SpaceStationRecruitment
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
    class SpaceStation
    {
        private string name;
        private int capacity;
        private List<Astronaut> data;

        public SpaceStation(string name, int capacity)
        {
            this.name = name;
            this.capacity = capacity;
            this.data = new List<Astronaut>();
        }
        public void Add(Astronaut astronaut)
        {
            if (data.Count < this.Capacity)
            {
                data.Add(astronaut);
            }
        }
        public bool Remove(string name)
        {
            //bool stats = false;
            //if (data.Any(n => n.Name == name))
            //{
            //    var index = data.IndexOf(data.FirstOrDefault(n => n.Name == name));
            //    data.RemoveAt(index);
            //    stats = true;
            //}
            //return stats;
            foreach (var item in this.data)
            {
                if(item.Name == name)
                {
                    data.Remove(item);
                    return true;
                }
            }
            return false;
        }

        public Astronaut GetOldestAstronaut()
        {
            Astronaut output = data.OrderByDescending(a => a.Age).First();
            return output;
        }
        public Astronaut GetAstronaut(string name)
        {
            Astronaut output = null;
            //Astronaut output = data.FirstOrDefault(a => a.Name == name);
            foreach (var astr in this.data)
            {
                if(astr.Name == name)
                {
                    output = astr;
                    break;
                }
            }
            return output;
        }
        public int Count
        {
            get => this.data.Count;
        }

        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Astronauts working at Space Station {this.Name}:");
            foreach (var astronaut in this.data)
            {
                sb.AppendLine($"{astronaut.ToString()}");
            }
            string output = sb.ToString().TrimEnd();
            return output;
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
