using MediatR;
using SpotifyLiteAlbum.Application.DTO;

namespace SpotifyLiteAlbum.Application.Handler.Command
{
    public class AtualizarBandaCommand : IRequest<AtualizarBandaCommandResponse>
    {
        public BandaOutputDto Banda { get; set; }
        public Guid IdBanda { get; set; }

        public AtualizarBandaCommand(BandaOutputDto banda)
        {
            Banda = banda;
        }
    }

    public class AtualizarBandaCommandResponse
    {
        public BandaOutputDto Banda { get; set; }

        public AtualizarBandaCommandResponse(BandaOutputDto banda)
        {
            Banda = banda;
        }
    }
}
