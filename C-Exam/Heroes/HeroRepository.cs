
namespace Heroes
{
using System;
using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class HeroRepository
    {
        private List<Hero> data;

        public HeroRepository()
        {
            this.data = new List<Hero>();
        }

        public void Add(Hero hero)
        {
            data.Add(hero);
        }

        public void Remove(string name)
        {
            var item = data.FirstOrDefault(h => h.Name == name);
            data.Remove(item);
        }

        public Hero GetHeroWithHighestStrength()
        {
            var hero = data.OrderByDescending(h => h.Item.Strength).First();
            return hero;
        }

public Hero GetHeroWithHighestAbility()
        {
            var hero = data.OrderByDescending(h => h.Item.Ability).First();
            return hero;
        }
        public Hero GetHeroWithHighestIntelligence()
        {
            var hero = data.OrderByDescending(h => h.Item.Intelligence).First();
            return hero;
        }
        public int Count { get  => this.data.Count; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var hero in data)
            {
                sb.AppendLine(hero.ToString());
            }
            return sb.ToString().TrimEnd();
        }


    }
}
