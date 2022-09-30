using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SpotifyLiteAlbum.Application.Service;

namespace SpotifyLiteAlbum.Application
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ConfigurationModule).Assembly);
            services.AddMediatR(typeof(ConfigurationModule).Assembly);

            services.AddScoped<IAlbumService, AlbumService>();
            services.AddScoped<IBandaService, BandaService>();
            services.AddScoped<IMusicaService, MusicaService>();
            services.AddScoped<AzureBlobStorage>();
            services.AddHttpClient();

            return services;
        }
    }
}
