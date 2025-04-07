using GameKeyStore.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameKeyStore.Data.FluidConfigs;

public class WarehouseConfig : IEntityTypeConfiguration<Warehouse>
{
    public void Configure(EntityTypeBuilder<Warehouse> builder)
    {
        builder.HasKey(w => w.id);

        builder.Property(w => w.Count)
            .HasDefaultValue(0);

        builder.HasOne(w => w.Game)
            .WithMany()
            .HasForeignKey(w => w.ProductId);
    }
}