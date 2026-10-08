using System;
using System.Collections.Generic;
using System.Text;
using CinemaDomain;
using FluentValidation;

namespace CinemaService.Validators
{
    public class FilmeValidators : AbstractValidator<Filme>
    {
            public FilmeValidators()
        {
            RuleFor(g => g.Nome)
                .NotEmpty().WithMessage("O nome do filme é obrigatório.")
                .NotNull().WithMessage("O nome do filme deve ser informado!")
                .Length(3, 200).WithMessage("O nome do filme deve ter entre 3 e 200 caracteres.");
            RuleFor(g => g.Duracao)
                .NotEmpty().WithMessage("A duração do filme é obrigatória.")
                .NotNull().WithMessage("A duração do filme deve ser informada!")
                .InclusiveBetween(1, 300).WithMessage("A duração do filme deve estar entre 1 e 300 minutos.");
            RuleFor(g => g.Classificacao)
                .NotEmpty().WithMessage("A classificação do filme é obrigatória.")
                .NotNull().WithMessage("A classificação do filme deve ser informada!")
                .Length(1, 18).WithMessage("A classificação do filme deve ter entre 1 e 18 caracteres.");
            RuleFor(g => g.Genero)
                .NotEmpty().WithMessage("O gênero do filme é obrigatório.")
                .NotNull().WithMessage("O gênero do filme deve ser informado!");
        }

    }
}
