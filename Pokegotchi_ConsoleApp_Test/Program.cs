using RestSharp;
using System.Text.Json;

RestResponse response = GetPokemon(1);

Pokemon pokemon = JsonSerializer.Deserialize<Pokemon>(response.Content);

Console.WriteLine($"Id: {pokemon.id}, Nome: {pokemon.name}, Altura: {pokemon.height}, Peso: {pokemon.weight}");

//Console.WriteLine(response.Content);

RestResponse GetPokemon(int id)
{
    var client = new RestClient($"https://pokeapi.co/api/v2/pokemon/{id}");

    var request = new RestRequest();

    return client.Execute(request);
}

public class Pokemon
{
    public int id { get; set; }
    public string name { get; set; }
    public int height { get; set; }
    public int weight { get; set; }
}