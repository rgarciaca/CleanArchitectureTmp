using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureTmp.Application.Features.Streamers.Commands.CreateStreamer
{
    public class UpdateStreamerCommandValidator : AbstractValidator<UpdateStreamerCommand>
    {
        public UpdateStreamerCommandValidator()
        {
            RuleFor(p => p.Nombre)
                .NotNull().WithMessage("{Nombre} no permite valores nulos");

            RuleFor(p => p.Url)
                .NotNull().WithMessage("La {Url} no permite valores nulos");
        }
    }
}
