﻿using MediatR;
using SpotifyLiteAlbum.Application.DTO;

namespace SpotifyLiteAlbum.Application.Handler.Command
{
    public class CriarMusicaCommand : IRequest<CriarMusicaCommandResponse>
    {
        public MusicaInputDto Musica { get; set; }
        public Guid IdBanda { get; set; }

        public CriarMusicaCommand(MusicaInputDto musica)
        {
            Musica = musica;
        }
    }

    public class CriarMusicaCommandResponse
    {
        public MusicaOutputDto Musica { get; set; }

        public CriarMusicaCommandResponse(MusicaOutputDto musica)
        {
            Musica = musica;
        }
    }
}
