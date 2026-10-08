using FluentValidation;
using CinemaDomain;

namespace CinemaService.Validators
{
    public class GeneroValidator : AbstractValidator<Genero>
    {
        public GeneroValidator()
        {
            RuleFor(g => g.Nome)
                .NotEmpty().WithMessage("O nome do gênero é obrigatório.")
                .NotNull().WithMessage("O nome do gênero deve ser informado!")
                .Length(5, 50).WithMessage("O nome do gênero deve ter entre 5 e 50 caracteres.")
                .MaximumLength(50).WithMessage("O nome do gênero não pode exceder 50 caracteres.");
        }

    }
}
