using CleanArchitectureTmp.Data;
using CleanArchitectureTmp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

StreamerDbContext dbContext = new();

//await AddNewRecords();

//QueryStreaming();

await QueryFilter();

async Task QueryFilter()
{
    var streamers = await dbContext!.Streamers!.Where(x => x.Nombre!.Contains("Amazon")).ToListAsync();
    foreach (var streamer in streamers)
    {
        Console.WriteLine($"{streamer.Id} - {streamer.Nombre}");
    }
}

void QueryStreaming()
{
    var Streamers = dbContext!.Streamers!.ToList();
    foreach (var streamer in Streamers)
    {
        Console.WriteLine($"{ streamer.Id} - { streamer.Nombre }");
    }
}

async Task AddNewRecords()
{
    Streamer streamer = new()
    {
        Nombre = "Disney +",
        Url = "https://www.disneyplus.com"
    };

    dbContext!.Streamers!.Add(streamer);

    await dbContext.SaveChangesAsync();

    var movies = new List<Video>()
    {
        new Video()
        {
            Nombre = "La cenicienta",
            StreamerId = streamer.Id,
        },
        new Video()
        {
            Nombre = "101 Dalmatas",
            StreamerId = streamer.Id,
        },
        new Video()
        {
            Nombre = "El jorobado de Notre Dame",
            StreamerId = streamer.Id,
        },
        new Video()
        {
            Nombre = "Star Wars",
            StreamerId = streamer.Id,
        }
    };

    await dbContext!.AddRangeAsync(movies);

    await dbContext.SaveChangesAsync();
}
