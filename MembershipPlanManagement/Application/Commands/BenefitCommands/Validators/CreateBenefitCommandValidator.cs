using FluentValidation;

namespace Application.Commands.BenefitCommands.Validators;

public class CreateBenefitCommandValidator : AbstractValidator<CreateBenefitCommand>
{
    public CreateBenefitCommandValidator()
    {
        RuleFor(x => x.Type)
                .NotEmpty().WithMessage("O tipo é obrigatório.");

        RuleFor(x => x.Age)
                .GreaterThan(0).WithMessage("A idade deve ser maior que 0.");

        RuleFor(x => x.Payout)
                .Must(p => int.TryParse(p, out var v) && v > 0)
                .WithMessage("O valor do benefício deve ser maior que 0.");

        RuleFor(x => x.Formula)
                .NotEmpty().WithMessage("A fórmula é obrigatória.");
    }
}