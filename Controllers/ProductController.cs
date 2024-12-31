using CQRSWithMediatR.Commands;
using CQRSWithMediatR.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSWithMediatR.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductCommand command)
        {
            var productId = await _mediator.Send(command);
            return Ok(new { Id = productId });
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _mediator.Send(new GetAllProductsQuery());
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var product = await _mediator.Send(new GetProductByIdQuery(id));
            return Ok(product);
        }
    }
}
