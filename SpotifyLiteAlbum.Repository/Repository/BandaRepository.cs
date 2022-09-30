using Microsoft.EntityFrameworkCore;
using SpotifyLiteAlbum.Domain.Models;
using SpotifyLiteAlbum.Domain.Repository;
using SpotifyLiteAlbum.Repository.Context;
using SpotifyLiteAlbum.Repository.Database;

namespace SpotifyLiteAlbum.Repository.Repository
{
    public class BandaRepository : Repository<Banda>, IBandaRepository
    {
        public BandaRepository(SpotifyAlbumContext context) : base(context)
        {
        }
    }
}
