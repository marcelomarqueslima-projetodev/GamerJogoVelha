using GamerJogoVelhaDomain.Entities;
using System;

namespace GamerJogoVelhaDomain.DTOs
{
    public class GameResultDto
    {
        public Game GameId { get; set; }
        public Player PlayerId { get; set; }
        public long? Win { get; set; } = null;
        public DateTime? LastGame { get; set; } = DateTime.UtcNow;
    }
}
