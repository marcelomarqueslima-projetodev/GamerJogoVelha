using GamerJogoVelhaDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GamerJogoVelhaInfraData.Mapping
{
    public class PlayerMapping : IEntityTypeConfiguration<Player>
    {

        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.ToTable("Player");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.PlayerName)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnName("PlayrName");
        }
    }
}
