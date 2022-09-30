using Microsoft.EntityFrameworkCore;
using SpotifyLiteAlbum.Domain.Models;
using SpotifyLiteAlbum.Domain.Repository;
using SpotifyLiteAlbum.Repository.Context;
using SpotifyLiteAlbum.Repository.Database;

namespace SpotifyLiteAlbum.Repository.Repository
{
    public class MusicaRepository : Repository<Musica>, IMusicaRepository
    {
        public MusicaRepository(SpotifyAlbumContext context) : base(context)
        {
        }
    }
}
