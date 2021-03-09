using GamerJogoVelhaDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GamerJogoVelhaInfraData.Mapping
{
    public class GameResultMapping : IEntityTypeConfiguration<GameResult>
    {
        public void Configure(EntityTypeBuilder<GameResult> builder)
        {
            builder.ToTable("GameResult");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Win)
                .HasColumnName("Win");

            builder.Property(c => c.LastGame)
                .HasColumnName("LastGame");
        }
    }
}
