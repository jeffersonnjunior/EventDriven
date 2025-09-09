using Application.Queries.BenefitQueries.Dtos;
using MediatR;

namespace Application.Queries.BenefitQueries;

public class GetOrderByIdQuery : IRequest<OrderDto?>
{
    public string Id { get; set; }
    public GetOrderByIdQuery(string id)
    {
        Id = id;
    }
}
