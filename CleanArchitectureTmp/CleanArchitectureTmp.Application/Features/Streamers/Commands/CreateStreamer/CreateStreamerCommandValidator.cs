﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureTmp.Application.Features.Streamers.Commands.CreateStreamer
{
    public class CreateStreamerCommandValidator : AbstractValidator<CreateStreamerCommand>
    {
        public CreateStreamerCommandValidator()
        {
            RuleFor(p => p.Nombre)
                .NotEmpty().WithMessage("{Nombre} no puede estar en blanco")
                .NotNull()
                .MaximumLength(50).WithMessage("{Nombre} no puede exceder 50 caracteres");

            RuleFor(p => p.Url)
                .NotEmpty().WithMessage("La {Url} no puede estar en blanco");
        }
    }
}
