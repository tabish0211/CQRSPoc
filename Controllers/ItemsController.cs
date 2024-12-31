using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/v1/[controller]")]
public class ItemsController : ControllerBase
{
    private readonly IMediator _mediator;

    public ItemsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateItem([FromBody] CreateItemCommand command)
    {
        var id = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetItems), new { id }, null);
    }

    [HttpGet]
    public async Task<IActionResult> GetItems()
    {
        var items = await _mediator.Send(new GetItemsQuery());
        return Ok(items);
    }
}
