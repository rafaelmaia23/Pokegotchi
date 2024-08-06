using Pokegotchi_ConsoleApp_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokegotchi_ConsoleApp_Test.Services
{
    public class TreinadorService
    {
        public Treinador CriarTreinador()
        {
            Console.WriteLine("Qual o seu nome?");
            string Nome = Console.ReadLine();
            Console.WriteLine("Qual a sua idade?");
            string Idade = Console.ReadLine();
            Treinador treinador = new Treinador(Nome, Idade);
            return treinador;
        }
    }
}
