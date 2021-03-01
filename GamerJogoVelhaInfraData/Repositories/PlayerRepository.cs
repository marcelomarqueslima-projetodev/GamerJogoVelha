using GamerJogoVelhaDomain.Entities;
using GamerJogoVelhaDomain.Interfaces.Repositories;
using GamerJogoVelhaInfraData.Context;
using System.Collections.Generic;

namespace GamerJogoVelhaInfraData.Repositories
{
    public class PlayerRepository : BaseRepository<Player, long>, IPlayerRepository
    {
        public PlayerRepository(ApplicationContext context) : base(context)
        {
        }

        public IList<Player> GetAll() => base.Select();

        public Player GetById(long id) => base.Select(id);

        public void Remove(long id)
        {
            base.Delete(id);
        }

        public void Save(Player player)
        {
            if (player.Id == 0)
            {
                base.Insert(player);
            }
            else
            {
                base.Update(player);
            }
        }
    }
}
