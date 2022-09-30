using AutoMapper;
using SpotifyLiteAlbum.Application.DTO;
using SpotifyLiteAlbum.Domain.Models;
using SpotifyLiteAlbum.Domain.Repository;

namespace SpotifyLiteAlbum.Application.Service
{
    public class BandaService : IBandaService
    {
        private readonly IBandaRepository bandaRepository;
        private readonly IMapper mapper;

        public BandaService(IBandaRepository bandaRepository, IMapper mapper)
        {
            this.bandaRepository = bandaRepository;
            this.mapper = mapper;
        }

        public async Task<BandaOutputDto> Criar(BandaInputDto dto)
        {
            var banda = this.mapper.Map<Banda>(dto);
            await this.bandaRepository.Save(banda);
            return this.mapper.Map<BandaOutputDto>(banda);
        }

        public async Task<List<BandaOutputDto>> ListarTodos()
        {
            var banda = await this.bandaRepository.GetAll();
            return this.mapper.Map<List<BandaOutputDto>>(banda);
        }

        public async Task<BandaOutputDto> BuscarPorID(string id)
        {
            var banda = await this.bandaRepository.Get(id);
            return this.mapper.Map<BandaOutputDto>(banda);
        }

        public async Task<BandaOutputDto> Atualizar(BandaOutputDto dto)
        {
            var banda = this.mapper.Map<Banda>(dto);
            await this.bandaRepository.Update(banda);
            return this.mapper.Map<BandaOutputDto>(banda);
        }

        public async Task<string> Remover(string id)
        {
            var banda = await this.bandaRepository.Get(id);
            await this.bandaRepository.Delete(banda);
            return id;
        }
    }
}