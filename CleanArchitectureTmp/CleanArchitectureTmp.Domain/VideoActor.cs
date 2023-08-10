using CleanArchitectureTmp.Domain.Common;

namespace CleanArchitectureTmp.Domain
{
    public class VideoActor : BaseDomainModel
    {
        public int VideoId { get; set; }
        public int ActorId { get; set; }

    }
}
