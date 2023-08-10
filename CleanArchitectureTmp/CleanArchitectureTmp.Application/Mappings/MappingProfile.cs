using AutoMapper;
using CleanArchitectureTmp.Application.Features.Streamers.Commands.CreateStreamer;
using CleanArchitectureTmp.Application.Features.Videos.Queries.GetVideosList;
using CleanArchitectureTmp.Domain;

namespace CleanArchitectureTmp.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Video, VideosVm>();
            CreateMap<UpdateStreamerCommand, Streamer>();
        }
    }
}
