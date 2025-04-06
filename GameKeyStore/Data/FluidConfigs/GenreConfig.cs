using GameKeyStore.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameKeyStore.Data.FluidConfigs;

public class GenreConfig : IEntityTypeConfiguration<Genre>
{
    public void Configure(EntityTypeBuilder<Genre> builder)
    {
        builder.HasKey(g => g.GenreName);

        builder.Property(g => g.GenreName)
            .IsRequired()
            .HasMaxLength(100);

        builder
            .HasMany(g => g.Games)
            .WithMany(gm => gm.Genres)
            .UsingEntity<GameGenre>(
                j => j
                    .HasOne(gg => gg.Game)
                    .WithMany()
                    .HasForeignKey(gg => gg.GameRef),
                j => j
                    .HasOne(gg => gg.Genre)
                    .WithMany()
                    .HasForeignKey(gg => gg.GenreRef),
                j =>
                {
                    j.HasKey(gg => new { gg.GameRef, gg.GenreRef });
                });
    }
}