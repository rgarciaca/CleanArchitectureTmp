using CleanArchitectureTmp.Domain;
using Microsoft.Extensions.Logging;

namespace CleanArchitectureTmp.Infrastructure.Persistence
{
    public class StreamerDbContextSeed
    {
        public static async Task SeedAsync(StreamerDbContext context, ILogger<StreamerDbContext> logger)
        {
            if (!context.Streamers!.Any())
            {
                context.Streamers!.AddRange(GetPreconfiguredStreamer());
                await context.SaveChangesAsync(CancellationToken.None);
                logger.LogInformation($"Insertando nuevos registros en DB {typeof(StreamerDbContext).Name}");
            }
        }

        private static IEnumerable<Streamer> GetPreconfiguredStreamer()
        {
            return new List<Streamer>
            {
                new Streamer
                {
                    CreatedBy = "rgarciaca",
                    Nombre = "HBO",
                    Url = "http://www.hbo.com"
                },
                new Streamer
                {
                    CreatedBy = "rgarciaca",
                    Nombre = "Amazon VIP",
                    Url = "http://www.amazonvip.com"

                }
            };
        }
    }
}
