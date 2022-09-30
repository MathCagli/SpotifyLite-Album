using MediatR;
using Microsoft.AspNetCore.Mvc;
using SpotifyLiteAlbum.Application.DTO;
using SpotifyLiteAlbum.Application.Handler.Command;
using SpotifyLiteAlbum.Application.Handler.Query;

namespace SpotifyLiteAlbum.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicaController : ControllerBase
    {
        private readonly IMediator mediator;

        public MusicaController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost("Criar")]
        public async Task<IActionResult> Criar(MusicaInputDto dto)
        {
            var result = await this.mediator.Send(new CriarMusicaCommand(dto));
            return Created($"{result.Musica.Id}", result.Musica);
        }

        [HttpGet("ListarTodos")]
        public async Task<IActionResult> ListarTodos()
        {
            return Ok(await this.mediator.Send(new ListarTodasMusicasQuery()));
        }

        [HttpGet("BuscarPorID/{id}")]
        public async Task<IActionResult> BuscarPorID(string id)
        {
            return Ok(await this.mediator.Send(new BuscarPorIDMusicaQuery { Id = id }));
        }

        [HttpPut("Atualizar")]
        public async Task<IActionResult> Atualizar(MusicaOutputDto dto)
        {
            var result = await this.mediator.Send(new AtualizarMusicaCommand(dto));
            return Ok(result);
        }

        [HttpDelete("Remover/{id}")]
        public async Task<IActionResult> Remover(string id)
        {
            return Ok(await this.mediator.Send(new RemoverMusicaCommand { Id = id }));
        }
    }
}