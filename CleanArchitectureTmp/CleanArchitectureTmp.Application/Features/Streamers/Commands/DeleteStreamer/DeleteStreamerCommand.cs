using MediatR;

namespace CleanArchitectureTmp.Application.Features.Streamers.Commands.CreateStreamer
{
    public class DeleteStreamerCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
