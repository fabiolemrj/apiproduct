using Microsoft.EntityFrameworkCore;
using musicmanager.Models;

namespace musicmanager.Data.MapsContext
{
    public class MusicAuthorMap : IEntityTypeConfiguration<MusicAuthor>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<MusicAuthor> builder)
        {
                     builder.ToTable("MusicAuthor");
            builder.HasKey(x => new { x.MusicId, x.AuthorId });
        }
    }
}