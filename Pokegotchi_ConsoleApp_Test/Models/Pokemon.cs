using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pokegotchi_ConsoleApp_Test.Models
{
    public class Pokemon
    {
        public int id { get; set; }
        public string name { get; set; }
        public int height { get; set; }
        public int weight { get; set; }
        public List<PokemonAbilities> abilities { get; set; }
        public List<PokemonType> types { get; set; }

        public void Aprensetar()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Id: {this.id}");
            Console.WriteLine($"Nome: {this.name}");
            Console.WriteLine($"Altura: {this.height}");
            Console.WriteLine($"Peso: {this.weight}");
            Console.WriteLine("Habilidades da especie: ");
            foreach (PokemonAbilities habilidade in this.abilities)
            {
                Console.WriteLine(habilidade.ability.name + " ");
            }
            Console.WriteLine("Tipos dessa especie: ");
            foreach (PokemonType tipos in this.types)
            {
                Console.WriteLine(tipos.type.name + " ");
            }
        }       
    }
}
