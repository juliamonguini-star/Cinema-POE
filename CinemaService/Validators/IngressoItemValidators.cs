using System;
using System.Collections.Generic;
using System.Text;
using CinemaDomain;
using FluentValidation;

namespace CinemaService.Validators
{
    public class IngressoItemValidator : AbstractValidator<IngressoItem>
    {
        public IngressoItemValidator()
        {
            RuleFor(i => i.Ingresso)
                .NotEmpty().WithMessage("Os itens do ingresso são obrigatórios.")
                .NotNull().WithMessage("Os itens do ingresso devem ser informados!");
            RuleFor(i => i.Assento)
               .NotEmpty().WithMessage("Os itens do ingresso são obrigatórios.")
               .NotNull().WithMessage("Os itens do ingresso devem ser informados!");
            RuleFor(i => i.Fileira)
               .NotEmpty().WithMessage("Os itens do ingresso são obrigatórios.")
               .NotNull().WithMessage("Os itens do ingresso devem ser informados!");
            RuleFor(i => i.MeiaEntrada)
               .NotEmpty().WithMessage("Os itens do ingresso são obrigatórios.")
               .NotNull().WithMessage("Os itens do ingresso devem ser informados!");
        }
    }
}