using MediatR;
using SpotifyLiteAlbum.Application.DTO;

namespace SpotifyLiteAlbum.Application.Handler.Query
{
    public class BuscarPorIDAlbumQuery : IRequest<BuscarPorIDAlbumQueryResponse>
    {
        public string Id { get; set; }
    }

    public class BuscarPorIDAlbumQueryResponse
    {
        public AlbumOutputDto Album { get; set; }

        public BuscarPorIDAlbumQueryResponse(AlbumOutputDto album)
        {
            Album = album;
        }
    }
}
