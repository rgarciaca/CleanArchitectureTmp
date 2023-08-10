using AutoMapper;
using CleanArchitectureTmp.Application.Contracts.Persistence;
using CleanArchitectureTmp.Application.Exceptions;
using CleanArchitectureTmp.Domain;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CleanArchitectureTmp.Application.Features.Streamers.Commands.CreateStreamer
{
    public class DeleteStreamerCommandHandler : IRequestHandler<DeleteStreamerCommand, Unit>
    {
        private readonly IStreamerRepository _streamerRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<DeleteStreamerCommandHandler> _logger;

        public DeleteStreamerCommandHandler(IStreamerRepository streamerRepository, IMapper mapper, ILogger<DeleteStreamerCommandHandler> logger)
        {
            _streamerRepository = streamerRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Unit> Handle(DeleteStreamerCommand request, CancellationToken cancellationToken)
        {
            var streamer = await _streamerRepository.GetByIdAsync(request.Id);
            if (streamer == null)
            {
                _logger.LogError($"No se encontro el streamer id {request.Id}");
                throw new NotFoundException(nameof(Streamer), request.Id);
            }

            await _streamerRepository.DeleteAsync(streamer);

            _logger.LogInformation($"Streamer {streamer.Id} fue eliminado correctamente.");

            return Unit.Value;
        }

    }
}
