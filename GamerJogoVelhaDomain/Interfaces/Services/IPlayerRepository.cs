using GamerJogoVelhaDomain.Entities;
using System.Collections.Generic;

namespace GamerJogoVelhaDomain.Interfaces.Services
{
    public interface IPlayerRepository
    {
        Player Insert(Player player);
        Player Update(Player player);
        void Delete(long id);
        Player RecoverById(long id);
        IList<Player> Browse();
    }
}
