using AutoMapper;
using GamerJogoVelhaDomain.DTOs;
using GamerJogoVelhaDomain.Entities;

namespace GamerJogoVelhaDomain.Profiles
{
    public class GamerJogoVelhaProfile : Profile
    {
        public GamerJogoVelhaProfile()
        {
            CreateMap<GameDto, Game>();
            CreateMap<Game, GameDto>().ReverseMap();

            CreateMap<PlayerDto, Player>();
            CreateMap<Player, PlayerDto>().ReverseMap();

            CreateMap<GameResultDto, GameResult>();
            CreateMap<GameResult, GameResultDto>().ReverseMap();
        }
    }
}
