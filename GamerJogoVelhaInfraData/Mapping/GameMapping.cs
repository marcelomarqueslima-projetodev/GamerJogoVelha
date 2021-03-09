using GamerJogoVelhaDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GamerJogoVelhaInfraData.Mapping
{
    public class GameMapping : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.ToTable("Game");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.NameGame)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnType("varchar(250)")
                .HasColumnName("GameName");

            builder.Property(c => c.SiglaGame)
                .IsRequired()
                .HasMaxLength(4)
                .HasColumnType("varchar(4)")
                .HasColumnName("SiglaGame");
        }
    }
}
