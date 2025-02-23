using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class ItemQueryController : ControllerBase
{
    private readonly IMediator _mediator;

    public ItemQueryController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetItemById(int id)
    {
        var query = new GetItemByIdQuery { Id = id };
        var item = await _mediator.Send(query);
        return Ok(item);
    }
}