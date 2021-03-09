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

            builder.Property(c => c.NamePlayer)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnType("varchar(250)")
                .HasColumnName("NamePlayer");

            builder.Property(c => c.SiglaPlayer)
                .IsRequired()
                .HasMaxLength(4)
                .HasColumnType("varchar(4)")
                .HasColumnName("SiglaPlayer");
        }
    }
}
