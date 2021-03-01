using GamerJogoVelhaDomain.Entities;
using GamerJogoVelhaDomain.Interfaces.Repositories;
using GamerJogoVelhaInfraData.Context;
using System;
using System.Collections.Generic;

namespace GamerJogoVelhaInfraData.Repositories
{
    public class GameRepository : BaseRepository<Game, long>, IGameRepository
    {
        public GameRepository(ApplicationContext context) : base(context)
        {
        }

        public IList<Game> GetAll() => base.Select();

        public Game GetById(long id) => base.Select(id);

        public Game GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(long id)
        {
            base.Delete(id);
        }

        public void Save(Game game)
        {
            if (game.Id == 0)
            {
                base.Insert(game);
            }
            else
            {
                base.Update(game);
            }
        }
    }
}
