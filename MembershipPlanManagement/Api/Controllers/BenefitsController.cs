using Application.Commands.BenefitCommands;
using Application.Queries.BenefitQueries;
using Application.Queries.BenefitQueries.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BenefitsController : ControllerBase
{
    private readonly IMediator _mediator;

    public BenefitsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateBenefitCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpGet("orders")]
    public async Task<ActionResult<List<OrderDto>>> GetAllOrders()
    {
        var result = await _mediator.Send(new GetAllOrdersQuery());
        return Ok(result);
    }

    [HttpGet("orders/{id}")]
    public async Task<ActionResult<OrderDto>> GetOrderById(string id)
    {
        var result = await _mediator.Send(new GetOrderByIdQuery(id));
        if (result == null)
            return NotFound();
        return Ok(result);
    }

    [HttpGet]
    public async Task<ActionResult<List<BenefitDto>>> GetAllBenefits()
    {
        var result = await _mediator.Send(new GetAllBenefitsQuery());
        return Ok(result);
    }
}
