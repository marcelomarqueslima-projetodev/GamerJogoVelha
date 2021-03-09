using GamerJogoVelhaDomain.Entities;
using System.Collections.Generic;

namespace GamerJogoVelhaDomain.Interfaces.Services
{
    public interface IGameService
    {
        Game Insert(Game game);
        Game Update(Game game);
        void Delete(long id);
        Game RecoverById(long id);
        IList<Game> Browse();
    }
}
