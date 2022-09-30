using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SpotifyLiteAlbum.Domain.Repository;
using SpotifyLiteAlbum.Repository.Context;
using SpotifyLiteAlbum.Repository.Database;
using SpotifyLiteAlbum.Repository.Repository;

namespace SpotifyLiteAlbum.Repository
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterRepository(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<SpotifyAlbumContext>(c =>
            {
                c.UseSqlServer(connectionString);
            });

            services.AddScoped(typeof(Repository<>));
            services.AddScoped<IAlbumRepository, AlbumRepository>();
            services.AddScoped<IBandaRepository, BandaRepository>();
            services.AddScoped<IMusicaRepository, MusicaRepository>();

            return services;
        }
    }
}
