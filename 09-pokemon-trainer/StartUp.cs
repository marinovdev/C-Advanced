using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_pokemon_trainer
{
    class StartUp
    {
        public static Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
        static void Main(string[] args)
        {
            //"{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"
            string command = "";
            while((command = Console.ReadLine()) != "Tournament")
            {
                var inputArr = command.Split();
                string trainerName = inputArr[0];
                string name = inputArr[1];
                string element = inputArr[2];
                int health = int.Parse(inputArr[3]);
                var pokemon = new Pokemon(name, element, health);
                var trainer = new Trainer(trainerName);
                if(!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, new Trainer(trainerName));
                }
                    trainers[trainerName].Pokemons.Add(pokemon);
            }
            string input = "";
            while((input = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Value.Pokemons.Any(p => p.Element == input))
                    {
                        trainer.Value.Badges += 1;   
                    }
                    else
                    {
                        foreach (var pokemon in trainer.Value.Pokemons)
                        {
                           pokemon.Health -= 10;
                        }
                        trainers[trainer.Key].RemoveDeadPokemons();
                    }
                }
            }
            foreach (var trainer in trainers.OrderByDescending(tr => tr.Value.Badges))
            {
                Console.WriteLine($"{trainer.Key} {trainer.Value.Badges} {trainer.Value.Pokemons.Count}");
            }
        }
    }
}
