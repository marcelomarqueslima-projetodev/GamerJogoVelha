using GamerJogoVelhaDomain.Entities;
using System;
using System.Collections.Generic;

namespace GamerJogoVelhaDomain.Interfaces.Repositories
{
    public interface IPlayerRepository
    {
        void Save(Player player);
        void Remove(long id);
        Player GetById(long id);
        IList<Player> GetAll();
    }
}
