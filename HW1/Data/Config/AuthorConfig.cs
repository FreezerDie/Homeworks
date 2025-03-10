using Library.Data.Contexts;
using Library.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Data.config;

public class AuthorConfig: IEntityTypeConfiguration<Author>
{

    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.ToTable("Author");
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.FullName)
            .HasMaxLength(50)
            .IsRequired();
        
    }
}