using GamerJogoVelhaDomain.Entities;
using System.Collections.Generic;

namespace GamerJogoVelhaDomain.Interfaces.Repositories
{
    public interface IGameRepository
    {
        void Save(Game game);
        void Remove(long id);
        Game GetById(long id);
        IList<Game> GetAll();
    }
}
