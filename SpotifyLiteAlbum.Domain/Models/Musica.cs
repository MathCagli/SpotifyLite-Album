using SpotifyLiteAlbum.CrossCutting.Entity;
using SpotifyLiteAlbum.Domain.ValueObject;

namespace SpotifyLiteAlbum.Domain.Models
{
    public class Musica : Entity<Guid>
    {
        public string Nome { get; set; }
        public Duracao Duracao { get; set; }
        public int Nota { get; set; }
        public int QtdVotos { get; set; }
    }
}
