using GamerJogoVelhaDomain.Entities;
using System.Collections.Generic;

namespace GamerJogoVelhaDomain.Interfaces.Repositories
{
    public interface IGameResultRepository
    {
        void Save(GameResult gameResult);
        void Remove(long id);
        GameResult GetById(long id);
        IList<GameResult> GetAll();
    }
}
