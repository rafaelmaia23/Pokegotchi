using Pokegotchi_ConsoleApp_Test.Models;
using Pokegotchi_ConsoleApp_Test.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokegotchi_ConsoleApp_Test.Views
{
    public class PokegotchiView
    {
        public void Saudacao()
        {
            Console.WriteLine("Bem Vindo ao Pokegotchi!");
            Console.WriteLine("Aqui você irá poder adotar um pokemon de sua preferência e cuidar dele para que ele cresca feliz e saudável");
        }
        public string MenuIniciar(Treinador treinador)
        {
            Console.WriteLine("-------------------------Menu-------------------------");
            Console.WriteLine($"{treinador.Nome}, o que você deseja fazer:");
            Console.WriteLine("1 - Adotar um pokemon");
            Console.WriteLine("2 - Ver seus pokemons");
            Console.WriteLine("3 - Sair"); 
            var opcao = Console.ReadLine();
            return opcao;
        }

        public void MenuDeAdocao(Treinador treinador)
        {
            Console.WriteLine("-------------------------Adotar um Pokemon-------------------------");
            Console.WriteLine($"{treinador.Nome}, Escolha uma espécie de Pokemon:");
        }

        public void SubMenuAdocao(Treinador treinador, Pokemon pokemon)
        {
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine($"Você escolheu {pokemon.name}, o que deseja fazer {treinador.Nome}?");
            Console.WriteLine($"1 - Saber Mais sobre o {pokemon.name}");
            Console.WriteLine($"2 - Adotar o {pokemon.name}");
            Console.WriteLine("3 - voltar");
        }

        public void MenuMascotes(Treinador treinador)
        {
            Console.WriteLine("-------------------------Menu Mascotes----------------------------");
            Console.WriteLine($"Você possui {treinador.Pokemons.Count} Pokemons adotados!");
            Console.WriteLine("Quem você gostaria de ver agora?");
            treinador.ListarPokemons();
        }
    }
}
