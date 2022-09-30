using SpotifyLiteAlbum.Application.DTO;

namespace SpotifyLiteAlbum.Application.Service
{
    public interface IAlbumService
    {
        Task<AlbumOutputDto> Criar(AlbumInputDto dto);
        Task<List<AlbumOutputDto>> ListarTodos();
        Task<AlbumOutputDto> BuscarPorID(string id);
        Task<AlbumOutputDto> Atualizar(AlbumOutputDto dto);
        Task<string> Remover(string id);
    }
}