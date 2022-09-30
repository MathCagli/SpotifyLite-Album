using Microsoft.EntityFrameworkCore;

namespace SpotifyLiteAlbum.Repository.Context
{
    public class SpotifyAlbumContext : DbContext
    {

        public SpotifyAlbumContext(DbContextOptions<SpotifyAlbumContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SpotifyAlbumContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
