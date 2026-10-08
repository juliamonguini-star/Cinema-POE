using System;
using System.Collections.Generic;
using System.Text;
using CinemaDomain;
using FluentValidation;

namespace CinemaService.Validators
{
   public class SessaoValidator : AbstractValidator<Sessao>
        {
            public SessaoValidator()
            {
            RuleFor(s => s.Filme)
               .NotEmpty().WithMessage("O nome do filme é obrigatório.")
               .NotNull().WithMessage("O nome do filme deve ser informado!");
                   
            RuleFor(s => s.Sala)
               .NotEmpty().WithMessage("O numero da sala é obrigatório.")
               .NotNull().WithMessage("O numero da sala deve ser informado!");

            RuleFor(s => s.Data)
               .NotEmpty().WithMessage("A data do filme é obrigatória.")
               .NotNull().WithMessage("A data do filme deve ser informada!");

            RuleFor(s => s.Preco)
               .NotEmpty().WithMessage("O preço do filme é obrigatório.")
               .NotNull().WithMessage("O preço do filme deve ser informado!");
        }
        }
    }