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

            builder.Property(c => c.GameName)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnName("GameName");
        }
    }
}
