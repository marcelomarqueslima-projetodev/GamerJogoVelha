using GamerJogoVelhaDomain.Entities;
using GamerJogoVelhaDomain.Interfaces.Repositories;
using GamerJogoVelhaInfraData.Context;
using System.Collections.Generic;

namespace GamerJogoVelhaInfraData.Repositories
{
    public class GameResultRepository : BaseRepository<GameResult, long>, IGameResultRepository
    {
        public GameResultRepository(GameContext context) : base(context)
        {
        }

        public IList<GameResult> GetAll() => base.Select();

        public GameResult GetById(long id) => base.Select(id);

        public void Remove(long id)
        {
            base.Delete(id);
        }

        public void Save(GameResult gameResult)
        {
            if (gameResult.GameId == 0 && gameResult.PlayerId == 0)
            {
                base.Insert(gameResult);
            }
            else
            {
                base.Update(gameResult);
            }
        }
    }
}
