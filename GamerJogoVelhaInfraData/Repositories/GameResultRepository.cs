using GamerJogoVelhaDomain.Interfaces.Repositories;
using GamerJogoVelhaDomain.Shareds;
using GamerJogoVelhaInfraData.Context;
using System.Collections.Generic;

namespace GamerJogoVelhaInfraData.Repositories
{
    public class GameResultRepository : BaseRepository<GameResult, long>, IGameResultRepository
    {
        public GameResultRepository(ApplicationContext context) : base(context)
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
            if (gameResult.Id == 0)
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
