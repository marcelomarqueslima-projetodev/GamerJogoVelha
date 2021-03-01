using GamerJogoVelhaDomain.Shareds;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerJogoVelhaDomain.Interfaces.Services
{
    public interface IGameResultService
    {
        GameResult Insert(GameResult gameResult);
        GameResult Update(GameResult gameResult);
        void Delete(long id);
        GameResult RecoverById(long id);
        IList<GameResult> Browse();
        void ValidateGame();
    }
}
