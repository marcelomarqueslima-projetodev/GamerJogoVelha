using FluentValidation;
using GamerJogoVelhaDomain.Entities;
using GamerJogoVelhaDomain.Interfaces.Repositories;
using GamerJogoVelhaDomain.Interfaces.Services;
using GamerJogoVelhaService.Validator;
using System;
using System.Collections.Generic;

namespace GamerJogoVelhaService.Services
{
    public class GameResultService : IGameResultService
    {
        private readonly IGameResultRepository _gameResultRepository;

        public GameResultService(IGameResultRepository gameResultRepository)
        {
            _gameResultRepository = gameResultRepository;
        }

        public IList<GameResult> Browse() => _gameResultRepository.GetAll();

        public void Delete(long id)
        {
            _gameResultRepository.Remove(id);
        }

        public GameResult Insert(GameResult gameResult)
        {
            ValidateGame(gameResult, new GameResultValidator());
            _gameResultRepository.Save(gameResult);
            return gameResult;
        }

        public GameResult RecoverById(long id) => _gameResultRepository.GetById(id);

        public GameResult Update(GameResult gameResult)
        {
            ValidateGame(gameResult, new GameResultValidator());
            _gameResultRepository.Save(gameResult);
            return gameResult;
            throw new NotImplementedException();
        }

        public void ValidateGame(GameResult gameResult, GameResultValidator validator)
        {
            if (gameResult == null)
                throw new Exception("Pais não encontrado!");
            validator.ValidateAndThrow(gameResult);
        }
    }
}
