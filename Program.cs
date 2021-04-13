using System;
using System.Collections.Generic;

namespace PokeDex
{
    class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string,int> pokemon = new Dictionary<string,int>();
           pokemon.Add("Wooper", 194);
           pokemon.Add("Clefable", 036);
           pokemon.Add("Chikorita", 152);
           pokemon.Add("Cyndaquil", 155);
           pokemon.Add("Lickitung", 108);
           pokemon.Add("Charmeleon", 005);
           pokemon.Add("Dwebble", 557);
           pokemon.Add("Inkay", 686);
           pokemon.Add("Meganium", 154);
           pokemon.Add("Lopunny", 428);

           Console.WriteLine("PokeDex");
           foreach (var key in pokemon.Keys)
           {
               Console.WriteLine("Nombre: " + key + " ID: " + pokemon.GetValueOrDefault(key));
           }
           
          //party 

        HashSet <PokeDex> partyPokemon = new HashSet<PokeDex>();
         partyPokemon.Add(new PokeDex("Meganium", 154, "Femenino"));
         partyPokemon.Add(new PokeDex("Charmeleon", 005, "Masculino"));
         partyPokemon.Add(new PokeDex("Charmeleon", 005, "Femenino"));
         partyPokemon.Add(new PokeDex("Wooper", 194, "Masculino"));
         partyPokemon.Add(new PokeDex("Dwebble", 557, "Femenino"));
         partyPokemon.Add(new PokeDex("Inkay", 686, "Masculino"));

        }
    }
}
