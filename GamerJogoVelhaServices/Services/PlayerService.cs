using FluentValidation;
using GamerJogoVelhaDomain.Entities;
using GamerJogoVelhaDomain.Interfaces.Repositories;
using GamerJogoVelhaDomain.Interfaces.Services;
using GamerJogoVelhaServices.Validator;
using System;
using System.Collections.Generic;

namespace GamerJogoVelhaServices.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _palyerRepository;

        public PlayerService(IPlayerRepository playerRepository)
        {
            _palyerRepository = playerRepository;
        }
        public IList<Player> Browse() => _palyerRepository.GetAll();

        public void Delete(long id)
        {
            _palyerRepository.Remove(id);
        }

        public Player Insert(Player player)
        {
            Validate(player, new PlayerValidator());
            _palyerRepository.Save(player);
            return player;

        }

        public Player RecoverById(int id) => _palyerRepository.GetById(id);

        public Player RecoverById(long id)
        {
            throw new NotImplementedException();
        }

        public Player Update(Player player)
        {
            Validate(player, new PlayerValidator());
            _palyerRepository.Save(player);
            return player;
            throw new NotImplementedException();
        }

        public void ValidateGame()
        {
            throw new NotImplementedException();
        }

        private void Validate(Player player, PlayerValidator validator)
        {
            if (player == null)
                throw new Exception("Pais não encontrado!");
            validator.ValidateAndThrow(player);
        }
    }
}
