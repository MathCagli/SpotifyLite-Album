using SpotifyLiteAlbum.Application.DTO;

namespace SpotifyLiteAlbum.Application.Service
{
    public interface IBandaService
    {
        Task<BandaOutputDto> Criar(BandaInputDto dto);
        Task<List<BandaOutputDto>> ListarTodos();
        Task<BandaOutputDto> BuscarPorID(string id);
        Task<BandaOutputDto> Atualizar(BandaOutputDto dto);
        Task<string> Remover(string id);
    }
}