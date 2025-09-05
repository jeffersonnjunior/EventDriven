using Domain.Enums;
using MediatR;

namespace Application.Commands.BenefitCommands;

public record CreateBenefitCommand(
    BenefitType Type,
    int? Age,
    string Payout,
    string Formula
) : IRequest<string>;
