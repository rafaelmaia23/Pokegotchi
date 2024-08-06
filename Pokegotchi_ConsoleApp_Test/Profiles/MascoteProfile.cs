using AutoMapper;
using Pokegotchi_ConsoleApp_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokegotchi_ConsoleApp_Test.Profiles
{
    internal class MascoteProfile : Profile
    {
        Random random = new Random();
        public MascoteProfile()
        {
            CreateMap<Pokemon, Mascote>().
                ForMember(dest => dest.PokedexId, opt => opt.MapFrom(src => src.id)).
                ForMember(dest => dest.Especie, opt => opt.MapFrom(src => src.name)).
                ForMember(dest => dest.Ability, opt => opt.MapFrom(src => src.abilities[random.Next(src.abilities.Count)])).
                ForMember(dest => dest.Height, opt => opt.MapFrom(src => src.height)).
                ForMember(dest => dest.Weight, opt => opt.MapFrom(src => src.weight)).
                ForMember(dest => dest.Types, opt => opt.MapFrom(src => src.types));
        }
    }
}
