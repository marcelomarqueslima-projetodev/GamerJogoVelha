using GamerJogoVelhaDomain.Entities;
using System.Collections.Generic;

namespace GamerJogoVelhaDomain.Interfaces.Services
{
    public interface IGameResultService
    {
        GameResult Insert(GameResult gameResult);
        GameResult Update(GameResult gameResult);
        void Delete(long id);
        GameResult RecoverById(long id);
        IList<GameResult> Browse();
    }
}
