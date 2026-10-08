using System;
using System.Collections.Generic;
using System.Text;
using CinemaDomain;
using FluentValidation;

namespace CinemaService.Validators
{
    public class IngressoValidator : AbstractValidator<Ingresso>
    {
        public IngressoValidator()
        {
            RuleFor(i => i.Sessao)
                .NotEmpty().WithMessage("A sessão é obrigatória.")
                .NotNull().WithMessage("A sessão deve ser informada!");
            RuleFor(i => i.DataCompra)
                .NotEmpty().WithMessage("A data da compra é obrigatória.")
                .NotNull().WithMessage("A data da compra deve ser informada!");
            RuleFor(i => i.FormaPagamento)
                .NotEmpty().WithMessage("A forma de pagamento é obrigatória.")
                .NotNull().WithMessage("A forma de pagamento deve ser informada!");
            RuleFor(i => i.ValorTotal)
                .NotEmpty().WithMessage("O valor do ingresso é obrigatório.")
                .NotNull().WithMessage("O valor do ingresso deve ser informado!");
        }
    }
}
                