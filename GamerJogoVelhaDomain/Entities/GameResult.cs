using System;
using System.Collections.Generic;
using System.Text;

namespace GamerJogoVelhaDomain.Entities
{
    public class GameResult : EntityBase<long>
    {
        public long GameId { get; set; }
        public Game Game { get; set; }
        public long PlayerId { get; set; }
        public Player Player { get; set; }
        public long? Win { get; set; } = null;
        public DateTime? LastGame { get; set; }
        public int? PartGame { get; set; } = 0;

        public void MakAsPartGame()
        {
            PartGame = PartGame + 1;
        }
    }
}
