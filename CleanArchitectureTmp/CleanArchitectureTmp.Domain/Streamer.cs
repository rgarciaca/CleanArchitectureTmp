using CleanArchitectureTmp.Domain.Common;

namespace CleanArchitectureTmp.Domain
{
    public class Streamer : BaseDomainModel
    {
        public string? Nombre { get; set; }
        public string? Url { get; set; }

        public ICollection<Video>? Videos { get; set; }
    }
}
