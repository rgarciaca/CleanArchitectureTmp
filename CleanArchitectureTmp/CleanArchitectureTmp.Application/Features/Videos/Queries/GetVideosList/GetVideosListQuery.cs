
using AutoMapper;
using CleanArchitectureTmp.Application.Contracts.Persistence;
using MediatR;

namespace CleanArchitectureTmp.Application.Features.Videos.Queries.GetVideosList
{
    public class GetVideosListQuery : IRequest<List<VideosVm>>
    {
        public string? Username { get; set; }

        public GetVideosListQuery(string _username)
        {
            Username = _username ?? throw new ArgumentNullException(nameof(_username));
        }
    }
}
