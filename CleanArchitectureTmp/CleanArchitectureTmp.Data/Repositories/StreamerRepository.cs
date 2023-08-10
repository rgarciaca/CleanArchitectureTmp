using CleanArchitectureTmp.Application.Contracts.Persistence;
using CleanArchitectureTmp.Domain;
using CleanArchitectureTmp.Infrastructure.Persistence;

namespace CleanArchitectureTmp.Infrastructure.Repositories
{
    public class StreamerRepository : RepositoryBase<Streamer>, IStreamerRepository
    {
        public StreamerRepository(StreamerDbContext _context) : base(_context) { }
    }
}
