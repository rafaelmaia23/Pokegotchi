using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokegotchi_ConsoleApp_Test.Models
{
    public class Mascote
    {
        Random random = new Random();
        public string Apelido { get; set; }
        public int PokedexId { get; set; }
        public string Especie { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public PokemonAbilities Ability { get; set; }
        public List<PokemonType> Types { get; set; }

        public int Fome { get; set; }
        public int Humor { get; set; }
        public int Limpeza { get; set; }
        public int Energia { get; set; }

        public Mascote(string apelido)
        {
            this.Apelido = apelido;
            this.Fome = random.Next(1, 11);
            this.Humor = random.Next(1, 11);
            this.Limpeza = random.Next(1, 11);
            this.Energia = random.Next(5, 11);
        }

        public void MostrarStatus()
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine($"Nesse momento {this.Apelido} está: ");
            Console.WriteLine($"Fome: {this.Fome}");
            Console.WriteLine($"Humor: {this.Humor}");
            Console.WriteLine($"Limpeza: {this.Limpeza}");
            Console.WriteLine($"Energia: {this.Energia}");
        }

        public void Brincar()
        {
            Humor++;
            Fome--;
            Limpeza--;
            Energia--;
        }

        public void Comer()
        {
            Fome += 4;
            Limpeza -= 3;
            Humor--;
            Energia--;
        }

        public void Dormir()
        {
            Fome -= 5;
            Limpeza -= 2;
            Humor -= 4;
            Energia += 7;
        }

        public void Limpar()
        {
            Fome--;
            Limpeza += 7;
            Humor -= 2;
            Energia -= 2;
        }
    }
}
