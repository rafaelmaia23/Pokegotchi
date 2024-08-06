using Pokegotchi_ConsoleApp_Test.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Pokegotchi_ConsoleApp_Test.Services
{
    public class PokemonService
    {
        public Pokemon GetPokemon(string especie)
        {
            var client = new RestClient($"https://pokeapi.co/api/v2/pokemon/{especie.ToLower()}");

            var request = new RestRequest();

            var response = client.Execute(request);

            if (response != null)
            {
                if (response.IsSuccessStatusCode)
                {
                    return JsonSerializer.Deserialize<Pokemon>(response.Content);
                }
                return null;
            }
            else
            {
                throw new Exception("Espécie não encontrada");
            }
        }
    }
}
