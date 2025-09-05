using Application.Commands.BenefitCommands;
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
}
