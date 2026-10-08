using System;
using System.Collections.Generic;
using System.Text;
using CinemaDomain;
using FluentValidation;

namespace CinemaService.Validators
{
        public class SalaValidator : AbstractValidator<Sala>
        {
            public SalaValidator()
            {
                RuleFor(s => s.Capacidade)
                    .NotEmpty().WithMessage("A capacidade da sala é obrigatória.")
                    .NotNull().WithMessage("A capacidade da sala deve ser informada!")
                    .InclusiveBetween(1, 1000).WithMessage("A capacidade da sala deve estar entre 1 e 1000.");
                RuleFor(s => s.Numero)
                    .NotEmpty().WithMessage("O número da sala é obrigatório.")
                    .NotNull().WithMessage("O número da sala deve ser informado!");
                RuleFor(s => s.Fileira)
                    .NotEmpty().WithMessage("A fileira da sala é obrigatória.")
                    .NotNull().WithMessage("A fileira da sala deve ser informada!");
                RuleFor(s => s.Assentos)
                    .NotEmpty().WithMessage("O número do assento da sala é obrigatório.")
                    .NotNull().WithMessage("O número do assento da sala deve ser informado!");
        }

        }
    }