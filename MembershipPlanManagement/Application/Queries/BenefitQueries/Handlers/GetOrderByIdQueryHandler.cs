using Application.Queries.BenefitQueries.Dtos;
using MediatR;
using MongoDB.Driver;
using MembershipPlanManagement.Infrastructure.Persistence.Context;

namespace Application.Queries.BenefitQueries.Handlers;

public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, OrderDto?>
{
    private readonly IMongoContext _mongoContext;
    public GetOrderByIdQueryHandler(IMongoContext mongoContext)
    {
        _mongoContext = mongoContext;
    }

    public async Task<OrderDto?> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
    {
        var collection = _mongoContext.GetCollection<OrderDto>("Orders");
        var filter = Builders<OrderDto>.Filter.Eq(o => o.Id, request.Id);
        return await collection.Find(filter).FirstOrDefaultAsync(cancellationToken);
    }
}
