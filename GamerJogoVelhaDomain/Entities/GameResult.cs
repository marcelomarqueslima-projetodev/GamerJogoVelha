using GamerJogoVelhaDomain.Entities;
using System;

namespace GamerJogoVelhaDomain.Shareds
{
    public class GameResult : BaseEntity<long>
    {
        public Game GameId { get; set; }
        public Player PlayerId { get; set; }
        public long? Win { get; set; } = null;
        public DateTime? LastGame { get; set; }
    }
}
