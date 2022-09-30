using System.ComponentModel.DataAnnotations;

namespace SpotifyLiteAlbum.Application.DTO
{
    public record BandaInputDto([Required(ErrorMessage = "Nome é obrigatório!")] string Nome, 
        [Required(ErrorMessage = "Descrição é obrigatória!")] string Descricao);
    public record BandaOutputDto(Guid Id, string Nome, string Descricao);
}