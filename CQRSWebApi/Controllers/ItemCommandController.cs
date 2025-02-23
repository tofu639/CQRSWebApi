using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class ItemCommandController : ControllerBase
{
    private readonly IMediator _mediator;

    public ItemCommandController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateItem(CreateItemCommand command)
    {
        var itemId = await _mediator.Send(command);
        return Ok(itemId);
    }
}