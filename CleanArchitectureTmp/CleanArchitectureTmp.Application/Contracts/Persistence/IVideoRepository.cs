using CleanArchitectureTmp.Domain;

namespace CleanArchitectureTmp.Application.Contracts.Persistence
{
    public interface IVideoRepository : IAsyncRepository<Video>
    {
        Task<Video> GetVideoByNombre(string nombre);
        Task<IEnumerable<Video>> GetVideoByUsername(string username);
    }
}
