using AutoMapper;
using SpotifyLiteAlbum.Application.DTO;
using SpotifyLiteAlbum.Domain.Models;
using SpotifyLiteAlbum.Domain.Repository;

namespace SpotifyLiteAlbum.Application.Service
{
    public class AlbumService : IAlbumService
    {
        private readonly IAlbumRepository albumRepository;
        private readonly IMapper mapper;
        private readonly IHttpClientFactory httpClientFactory;
        private readonly AzureBlobStorage storage;

        public AlbumService(IAlbumRepository albumRepository, IMapper mapper, IHttpClientFactory httpClientFactory, AzureBlobStorage storage)
        {
            this.albumRepository = albumRepository;
            this.mapper = mapper;
            this.httpClientFactory = httpClientFactory;
            this.storage = storage;
        }

        public async Task<AlbumOutputDto> Criar(AlbumInputDto dto)
        {
            var album = this.mapper.Map<Album>(dto);
            HttpClient httpClient = this.httpClientFactory.CreateClient();
            using var response = await httpClient.GetAsync(dto.Capa);
            if (response.IsSuccessStatusCode)
            {
                using var stream = await response.Content.ReadAsStreamAsync();
                var fileName = $"{Guid.NewGuid()}.jpg";
                var pathStorage = await this.storage.UploadFile(fileName, stream);
                album.Capa = pathStorage;
            }
            await this.albumRepository.Save(album);
            return this.mapper.Map<AlbumOutputDto>(album);
        }

        public async Task<List<AlbumOutputDto>> ListarTodos()
        {
            var album = await this.albumRepository.GetAll();
            return this.mapper.Map<List<AlbumOutputDto>>(album);
        }

        public async Task<AlbumOutputDto> BuscarPorID(string id)
        {
            var album = await this.albumRepository.Get(id);
            return this.mapper.Map<AlbumOutputDto>(album);
        }

        public async Task<AlbumOutputDto> Atualizar(AlbumOutputDto dto)
        {
            var album = this.mapper.Map<Album>(dto);
            await this.albumRepository.Update(album);
            return this.mapper.Map<AlbumOutputDto>(album);
        }

        public async Task<string> Remover(string id)
        {
            var album = await this.albumRepository.Get(id);
            await this.albumRepository.Delete(album);
            return id;
        }
    }
}