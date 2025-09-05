using Domain.Entities;
using Infrastructure.Interfaces.IPersistence;
using MediatR;

namespace Application.Commands.BenefitCommands.Handlers;

public class CreateBenefitCommandHandler : IRequestHandler<CreateBenefitCommand, string>
{
    private readonly IMongoContext _mongoContext;

    public CreateBenefitCommandHandler(IMongoContext mongoContext)
    {
        _mongoContext = mongoContext;
    }

    public async Task<string> Handle(CreateBenefitCommand request, CancellationToken cancellationToken)
    {
        var benefit = new Benefit
        {
            Type = request.Type,
            Age = request.Age,
            Payout = request.Payout,
            Formula = request.Formula
        };

        await _mongoContext.GetCollection<Benefit>("Benefits").InsertOneAsync(benefit, cancellationToken: cancellationToken);

        return benefit.Payout.ToString() ?? string.Empty;
    }
}