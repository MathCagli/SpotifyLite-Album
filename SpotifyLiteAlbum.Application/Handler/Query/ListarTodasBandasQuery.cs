using MediatR;
using SpotifyLiteAlbum.Application.DTO;

namespace SpotifyLiteAlbum.Application.Handler.Query
{
    public class ListarTodasBandasQuery : IRequest<ListarTodasBandasQueryResponse>
    {
    }

    public class ListarTodasBandasQueryResponse
    {
        public IList<BandaOutputDto> Bandas { get; set; }

        public ListarTodasBandasQueryResponse(IList<BandaOutputDto> bandas)
        {
            Bandas = bandas;
        }
    }
}
