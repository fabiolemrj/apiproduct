using Microsoft.EntityFrameworkCore;
using musicmanager.Data.MapsContext;
using musicmanager.Models;

namespace musicmanager.Data
{
    public class DataContext:DbContext
    {
        
     

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            var str = "Server=localhost;Database=ecad;Integrated Security=True;";
             optionsBuilder.UseInMemoryDatabase("Database");
          //  var str = Settings.ConnectionString;
           // optionsBuilder.UseSqlServer(str);
            //base.OnConfiguring(optionsBuilder);
        }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MusicMap());
            modelBuilder.ApplyConfiguration(new AuthorMap());
            modelBuilder.ApplyConfiguration(new MusicAuthorMap());
        }
            public DbSet<Music> Musics { get; set; }
            public DbSet<Author> Authors { get; set; }
            public DbSet<MusicAuthor> MusicAuthors { get; set; }
    }
}