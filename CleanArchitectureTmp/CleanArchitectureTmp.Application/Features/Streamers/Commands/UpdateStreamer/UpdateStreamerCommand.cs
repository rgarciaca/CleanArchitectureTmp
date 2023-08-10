using MediatR;

namespace CleanArchitectureTmp.Application.Features.Streamers.Commands.CreateStreamer
{
    public class UpdateStreamerCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;

    }
}
