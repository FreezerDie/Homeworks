using GameKeyStore.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameKeyStore.Data.FluidConfigs;

public class GameConfig : IEntityTypeConfiguration<Game>
{
    public void Configure(EntityTypeBuilder<Game> builder)
    {
        builder.HasKey(g => g.Id);

        builder.Property(g => g.GameName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(g => g.ImagePath)
            .HasMaxLength(255);

        builder.Property(g => g.Publisher)
            .HasMaxLength(100);

        builder.Property(g => g.Price)
            .HasColumnType("decimal(18,2)");

        builder.HasMany(g => g.Genres)
            .WithMany()
            .UsingEntity<GameGenre>(
                j => j
                    .HasOne(gg => gg.Genre)
                    .WithMany()
                    .HasForeignKey(gg => gg.GenreRef),
                j => j
                    .HasOne(gg => gg.Game)
                    .WithMany()
                    .HasForeignKey(gg => gg.GameRef),
                j =>
                {
                    j.HasKey(gg => new { gg.GameRef, gg.GenreRef });
                });
    }
}
