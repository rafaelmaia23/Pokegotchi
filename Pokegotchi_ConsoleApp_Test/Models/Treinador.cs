using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokegotchi_ConsoleApp_Test.Models
{
    public class Treinador
    {
        public string Nome { get; set; }
        public string Idade { get; set; }
        public List<Mascote> Pokemons { get; set; }

        public Treinador(string nome, string idade)
        {
            Nome = nome;
            Idade = idade;
            Pokemons = new List<Mascote>(6);
        }

        public void ListarPokemons()
        {
            if(Pokemons.Count == 0)
            {
                Console.WriteLine("Nenhum pokemon foi adotado ainda");
            }
            else
            {
                foreach(Mascote pokemon in this.Pokemons)
                {
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine($"{Pokemons.IndexOf(pokemon) + 1} - {pokemon.Apelido}");
                    //Console.WriteLine($"id {pokemon.PokedexId}");
                    //Console.WriteLine($"especie {pokemon.Especie}");
                    //Console.WriteLine($"height {pokemon.Height}");
                    //Console.WriteLine($"weight {pokemon.Weight}");                   
                    //Console.WriteLine($"abilidade {pokemon.Ability.ability.name}");
                    //foreach(PokemonType type in pokemon.Types)
                    //{
                    //    Console.WriteLine($"tipo {type.type.name}");

                    //}
                    //Console.WriteLine($"{pokemon.Fome}");
                    //Console.WriteLine($"{pokemon.Humor}");
                    //Console.WriteLine($"{pokemon.Limpeza}");
                    //Console.WriteLine($"{pokemon.Energia}");

                }
            }
        }
    }
}
