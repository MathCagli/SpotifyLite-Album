using MediatR;
using SpotifyLiteAlbum.Application.DTO;

namespace SpotifyLiteAlbum.Application.Handler.Command
{
    public class CriarBandaCommand : IRequest<CriarBandaCommandResponse>
    {
        public BandaInputDto Banda { get; set; }

        public CriarBandaCommand(BandaInputDto banda)
        {
            Banda = banda;
        }
    }

    public class CriarBandaCommandResponse
    {
        public BandaOutputDto Banda { get; set; }

        public CriarBandaCommandResponse(BandaOutputDto banda)
        {
            Banda = banda;
        }
    }
}
