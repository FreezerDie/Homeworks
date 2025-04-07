using GameKeyStore.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameKeyStore.Data.FluidConfigs;

public class GameGenreConfig : IEntityTypeConfiguration<GameGenre>
{
    public void Configure(EntityTypeBuilder<GameGenre> builder)
    {
        
        builder.HasKey(gg => gg.id);

        builder.HasOne(gg => gg.Game)
            .WithMany()
            .HasForeignKey(gg => gg.GameRef);

        builder.HasOne(gg => gg.Genre)
            .WithMany()
            .HasForeignKey(gg => gg.GenreRef);
    }
}