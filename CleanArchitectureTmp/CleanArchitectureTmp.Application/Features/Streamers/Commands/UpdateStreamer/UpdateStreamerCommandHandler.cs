using AutoMapper;
using CleanArchitectureTmp.Application.Contracts.Persistence;
using CleanArchitectureTmp.Application.Exceptions;
using CleanArchitectureTmp.Application.Models;
using CleanArchitectureTmp.Domain;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CleanArchitectureTmp.Application.Features.Streamers.Commands.CreateStreamer
{
    public class UpdateStreamerCommandHandler : IRequestHandler<UpdateStreamerCommand, int>
    {
        private readonly IStreamerRepository _streamerRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateStreamerCommandHandler> _logger;

        public UpdateStreamerCommandHandler(IStreamerRepository streamerRepository, IMapper mapper, ILogger<UpdateStreamerCommandHandler> logger)
        {
            _streamerRepository = streamerRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<int> Handle(UpdateStreamerCommand request, CancellationToken cancellationToken)
        {
            var streamer = await _streamerRepository.GetByIdAsync(request.Id);
            if (streamer == null)
            {
                _logger.LogError($"No se encontro el streamer id {request.Id}");
                throw new NotFoundException(nameof(Streamer), request.Id);
            }

            _mapper.Map(request, streamer, typeof(UpdateStreamerCommand), typeof(Streamer));
            var updatedStreamer = await _streamerRepository.UpdateAsync(streamer);

            _logger.LogInformation($"Streamer {updatedStreamer.Id} fue actualizado correctamente.");

            return updatedStreamer.Id;
        }
    }
}
