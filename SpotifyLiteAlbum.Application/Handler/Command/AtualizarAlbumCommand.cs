﻿using MediatR;
using SpotifyLiteAlbum.Application.DTO;

namespace SpotifyLiteAlbum.Application.Handler.Command
{
    public class AtualizarAlbumCommand : IRequest<AtualizarAlbumCommandResponse>
    {
        public AlbumOutputDto Album { get; set; }
        public Guid IdBanda { get; set; }

        public AtualizarAlbumCommand(AlbumOutputDto album)
        {
            Album = album;
        }
    }

    public class AtualizarAlbumCommandResponse
    {
        public AlbumOutputDto Album { get; set; }

        public AtualizarAlbumCommandResponse(AlbumOutputDto album)
        {
            Album = album;
        }
    }
}
