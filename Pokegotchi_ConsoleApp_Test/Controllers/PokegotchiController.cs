using AutoMapper;
using Pokegotchi_ConsoleApp_Test.Models;
using Pokegotchi_ConsoleApp_Test.Profiles;
using Pokegotchi_ConsoleApp_Test.Services;
using Pokegotchi_ConsoleApp_Test.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokegotchi_ConsoleApp_Test.Controllers
{
    public class PokegotchiController
    {
        PokemonService pokemonService = new PokemonService();
        TreinadorService treinadorService = new TreinadorService();
        PokegotchiView pokegotchiView = new PokegotchiView();
        Treinador treinador;
        Pokemon? pokemon;

        static MapperConfiguration config = new MapperConfiguration(cfg => {
            cfg.AddProfile<MascoteProfile>();
        });
        IMapper mapper = config.CreateMapper();

        public void Jogar()
        {
            
            int jogar = 1;
            string opcao;

            pokegotchiView.Saudacao();

            treinador = treinadorService.CriarTreinador();

            while (jogar == 1)
            {
                opcao = pokegotchiView.MenuIniciar(treinador);
                switch (opcao)
                {
                    case "1":
                        MenuAdocao();
                        break;
                    case "2":
                        MenuPokemons();
                        break;
                    case "3":
                        jogar = 0;
                        break;
                    default:
                        Console.WriteLine("Opção Inválida! Tente Novamente: ");
                        break;
                }

            }
        }         

        public void MenuAdocao()
        {
            pokegotchiView.MenuDeAdocao(treinador);
            string especie = Console.ReadLine();
            pokemon = pokemonService.GetPokemon(especie);
            while (pokemon == null)
            {
                Console.WriteLine("especie invalida, tente novamente");
                especie = Console.ReadLine();
                pokemon = pokemonService.GetPokemon(especie);
            }
            string opcao = "1";
            while (opcao != "3")
            {
                pokegotchiView.SubMenuAdocao(treinador, pokemon);
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        pokemon.Aprensetar();
                        break;
                    case "2":
                        Console.WriteLine($"Qual nome você quer dar para {pokemon.name}?");
                        string apelido = Console.ReadLine();
                        Mascote mascote = new Mascote(apelido);
                        mapper.Map<Pokemon, Mascote>(pokemon, mascote);
                        treinador.Pokemons.Add(mascote);
                        Console.WriteLine("Pokemon adotado com sucesso");
                        opcao = "3";
                        break;
                    case "3":
                        opcao = "3";
                        break;                        
                    default:
                        Console.WriteLine("Opção Inválida! Tente Novamente: ");
                        break;
                }
            }
        }

        private void MenuPokemons()
        {
            pokegotchiView.MenuMascotes(treinador);
            string opcao = Console.ReadLine();
            
        }
    }
}
