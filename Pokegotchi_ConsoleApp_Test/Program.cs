using Pokegotchi_ConsoleApp_Test.Controllers;
using Pokegotchi_ConsoleApp_Test.Models;
using Pokegotchi_ConsoleApp_Test.Views;
using RestSharp;
using System.Text.Json;

class Program
{
    static void Main()
    {
        PokegotchiController pokegotchiController = new PokegotchiController();

        pokegotchiController.Jogar();
    }
}