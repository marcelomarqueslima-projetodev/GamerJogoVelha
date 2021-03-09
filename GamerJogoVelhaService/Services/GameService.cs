using FluentValidation;
using GamerJogoVelhaDomain.Entities;
using GamerJogoVelhaDomain.Interfaces.Repositories;
using GamerJogoVelhaDomain.Interfaces.Services;
using GamerJogoVelhaService.Validator;
using System;
using System.Collections.Generic;

namespace GamerJogoVelhaService.Services
{
    public class GameService : IGameService
    {
        private readonly IGameRepository _gameRepository;

        public GameService(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }
        public IList<Game> Browse() => _gameRepository.GetAll();

        public void Delete(long id)
        {
            _gameRepository.Remove(id);
        }

        public Game Insert(Game game)
        {
            Validate(game, new GameValidator());
            _gameRepository.Save(game);
            return game;

        }

        public Game RecoverById(long id) => _gameRepository.GetById(id);

        public Game Update(Game game)
        {
            Validate(game, new GameValidator());
            _gameRepository.Save(game);
            return game;
            throw new NotImplementedException();
        }

        private void Validate(Game game, GameValidator validator)
        {
            if (game == null)
                throw new Exception("Pais não encontrado!");
            validator.ValidateAndThrow(game);
        }
    }
}
