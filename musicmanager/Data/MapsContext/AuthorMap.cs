using Microsoft.EntityFrameworkCore;
using musicmanager.Models;

namespace musicmanager.Data.MapsContext
{
    public class AuthorMap : IEntityTypeConfiguration<Author>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Author> builder)
        {
                        builder.ToTable("Author");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
            builder.Property(x => x.Code).IsRequired().HasMaxLength(6).HasColumnType("varchar(6)");
            builder.Property(x => x.Category).IsRequired().HasColumnType("int"); 
        }
    }
}