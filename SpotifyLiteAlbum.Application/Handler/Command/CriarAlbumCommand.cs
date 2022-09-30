using MediatR;
using SpotifyLiteAlbum.Application.DTO;

namespace SpotifyLiteAlbum.Application.Handler.Command
{
    public class CriarAlbumCommand : IRequest<CriarAlbumCommandResponse>
    {
        public AlbumInputDto Album { get; set; }
        public Guid IdBanda { get; set; }

        public CriarAlbumCommand(AlbumInputDto album)
        {
            Album = album;
        }
    }

    public class CriarAlbumCommandResponse
    {
        public AlbumOutputDto Album { get; set; }

        public CriarAlbumCommandResponse(AlbumOutputDto album)
        {
            Album = album;
        }
    }
}
