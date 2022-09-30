using SpotifyLiteAlbum.Application.DTO;
using SpotifyLiteAlbum.Domain.Models;

namespace SpotifyLiteAlbum.Application.Profile
{
    public class Profile : AutoMapper.Profile
    {
        public Profile()
        {
            // Album
            CreateMap<AlbumInputDto, Album>();
            CreateMap<Album, AlbumOutputDto>();
            CreateMap<AlbumOutputDto, Album>();

            // Banda
            CreateMap<BandaInputDto, Banda>();
            CreateMap<Banda, BandaOutputDto>();
            CreateMap<BandaOutputDto, Banda>();

            // Música
            CreateMap<MusicaInputDto, Musica>()
                .ForPath(x => x.Duracao.Valor, f => f.MapFrom(m => m.Duracao));
            CreateMap<Musica, MusicaOutputDto>()
                .ForMember(x => x.Duracao, f => f.MapFrom(m => m.Duracao.ValorFormatado()));
            CreateMap<MusicaOutputDto, Musica>()
                .ForPath(x => x.Duracao.Valor, f => f.MapFrom(m => m.Duracao));
        }
    }
}