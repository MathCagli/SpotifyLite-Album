using MediatR;
using SpotifyLiteAlbum.Application.DTO;

namespace SpotifyLiteAlbum.Application.Handler.Query
{
    public class ListarTodosAlbunsQuery : IRequest<ListarTodosAlbunsQueryResponse>
    {
    }

    public class ListarTodosAlbunsQueryResponse
    {
        public IList<AlbumOutputDto> Albuns { get; set; }

        public ListarTodosAlbunsQueryResponse(IList<AlbumOutputDto> albuns)
        {
            Albuns = albuns;
        }
    }
}
