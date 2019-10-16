
namespace _09_pokemon_trainer
{
using System;
using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class Trainer
    {
        private string name;
        private int badges;
        private List<Pokemon> pokemons;
        public Trainer(string name)
        {
            this.Name = name;
            this.Badges = 0;
            this.Pokemons = new List<Pokemon>();
        }
        
        //public void ReduceHealth()
        //{

        //    Pokemons = Pokemons.Select(p => p.Health -= 10);
        //}
        public void RemoveDeadPokemons()
        {
            Pokemons = Pokemons.Where(p => p.Health > 0).ToList();
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Badges
        {
            get { return badges; }
            set { badges = value; }
        }
        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
            set { pokemons = value; }
        }
    }
}
