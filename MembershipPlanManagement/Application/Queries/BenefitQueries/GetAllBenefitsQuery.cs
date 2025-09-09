using Application.Queries.BenefitQueries.Dtos;
using MediatR;
using System.Collections.Generic;

namespace Application.Queries.BenefitQueries;

public class GetAllBenefitsQuery : IRequest<List<BenefitDto>>
{
    // Filtros podem ser adicionados aqui futuramente
}
