using Application.Queries.BenefitQueries.Dtos;
using MediatR;
using MongoDB.Driver;
using Infrastructure.Interfaces.IPersistence;

namespace Application.Queries.BenefitQueries.Handlers;

public class GetAllBenefitsQueryHandler : IRequestHandler<GetAllBenefitsQuery, List<BenefitDto>>
{
    private readonly IMongoContext _mongoContext;
    public GetAllBenefitsQueryHandler(IMongoContext mongoContext)
    {
        _mongoContext = mongoContext;
    }

    public async Task<List<BenefitDto>> Handle(GetAllBenefitsQuery request, CancellationToken cancellationToken)
    {
        var collection = _mongoContext.GetCollection<BenefitDto>("Benefits");
        return await collection.Find(_ => true).ToListAsync(cancellationToken);
    }
}
