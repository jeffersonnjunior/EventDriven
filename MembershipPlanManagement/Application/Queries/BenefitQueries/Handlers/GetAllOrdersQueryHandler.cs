using Application.Queries.BenefitQueries.Dtos;
using MediatR;
using MongoDB.Driver;
using MembershipPlanManagement.Infrastructure.Persistence.Context;

namespace Application.Queries.BenefitQueries.Handlers;

public class GetAllOrdersQueryHandler : IRequestHandler<GetAllOrdersQuery, List<OrderDto>>
{
    private readonly IMongoContext _mongoContext;
    public GetAllOrdersQueryHandler(IMongoContext mongoContext)
    {
        _mongoContext = mongoContext;
    }

    public async Task<List<OrderDto>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
    {
        var collection = _mongoContext.GetCollection<OrderDto>("Orders");
        return await collection.Find(_ => true).ToListAsync(cancellationToken);
    }
}
