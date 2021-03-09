using GamerJogoVelhaDomain.Entities;
using GamerJogoVelhaInfraData.Mapping;
using Microsoft.EntityFrameworkCore;

namespace GamerJogoVelhaInfraData.Context
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options) : base(options) { }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<GameResult> GameResults { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameResult>()
                .HasKey(AD => new { AD.PlayerId, AD.GameId });

            modelBuilder.ApplyConfiguration(new GameMapping());
            modelBuilder.ApplyConfiguration(new PlayerMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
