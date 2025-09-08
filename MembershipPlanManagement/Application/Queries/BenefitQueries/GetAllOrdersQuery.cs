using Application.Queries.BenefitQueries.Dtos;
using MediatR;

namespace Application.Queries.BenefitQueries;

public class GetAllOrdersQuery : IRequest<List<OrderDto>>
{
    // Você pode adicionar filtros ou paginação futuramente
}
