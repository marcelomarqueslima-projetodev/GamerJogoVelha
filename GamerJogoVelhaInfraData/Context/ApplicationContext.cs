using GamerJogoVelhaDomain.Entities;
using GamerJogoVelhaDomain.Shareds;
using GamerJogoVelhaInfraData.Mapping;
using Microsoft.EntityFrameworkCore;

namespace GamerJogoVelhaInfraData.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<GameResult> GameResults { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GameMapping());
            modelBuilder.ApplyConfiguration(new PlayerMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
