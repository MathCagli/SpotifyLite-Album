using MediatR;
using SpotifyLiteAlbum.Application.DTO;

namespace SpotifyLiteAlbum.Application.Handler.Command
{
    public class RemoverAlbumCommand : IRequest<RemoverAlbumCommandResponse>
    {
        public string Id { get; set; }
    }

    public class RemoverAlbumCommandResponse
    {
        public string Id { get; set; }

        public RemoverAlbumCommandResponse(string id)
        {
            Id = id;
        }
    }
}
