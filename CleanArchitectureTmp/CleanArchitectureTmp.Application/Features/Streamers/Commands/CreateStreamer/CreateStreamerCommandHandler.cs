using AutoMapper;
using CleanArchitectureTmp.Application.Contracts.Persistence;
using CleanArchitectureTmp.Application.Models;
using CleanArchitectureTmp.Domain;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CleanArchitectureTmp.Application.Features.Streamers.Commands.CreateStreamer
{
    public class CreateStreamerCommandHandler : IRequestHandler<CreateStreamerCommand, int>
    {
        private readonly IStreamerRepository _streamerRepository;
        private readonly IMapper _mapper;
       // private readonly IEmailService _emailService;
        private readonly ILogger<CreateStreamerCommandHandler> _logger;

        public CreateStreamerCommandHandler(IStreamerRepository streamerRepository, IMapper mapper, ILogger<CreateStreamerCommandHandler> logger)
        {
            _streamerRepository = streamerRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<int> Handle(CreateStreamerCommand request, CancellationToken cancellationToken)
        {
            var streamerEntity = _mapper.Map<Streamer>(request);
            var newStreamer = await _streamerRepository.AddAsync(streamerEntity);

            _logger.LogInformation($"Streamer {newStreamer.Id} fue creado satisfactoriamente.");
            await SendEmail(newStreamer);

            return newStreamer.Id;
        }

        private async Task SendEmail(Streamer streamer)
        {
            var email = new Email
            {
                To = "rgarciaca@outlook.com",
                Body = "La compañia de streamer se creo correctamente.",
                Subject = "Mensaje de alerta"
            };

            //try
            //{
            //    await _emailService.SendEmail(email);
            //}
            //catch (Exception ex)
            //{
            //    _logger.LogError($"Error enviando el email del Streamer {streamer.Id}");
            //}

        }
    }
}
