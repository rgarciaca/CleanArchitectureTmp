using CleanArchitectureTmp.Application.Contracts.Persistence;
using CleanArchitectureTmp.Domain;
using CleanArchitectureTmp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureTmp.Infrastructure.Repositories
{
    public class VideoRepository : RepositoryBase<Video>, IVideoRepository
    {
        public VideoRepository(StreamerDbContext _context) : base(_context) { }

        public async Task<Video> GetVideoByNombre(string nombre)
        {
            return await _context.Videos!.Where(o => o.Nombre == nombre).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Video>> GetVideoByUsername(string username)
        {
            return await _context.Videos!.Where(o => o.CreatedBy == username).ToListAsync();
        }
    }
}
