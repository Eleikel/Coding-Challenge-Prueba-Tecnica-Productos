using Microsoft.AspNetCore.Mvc;
using ProductManager.Core.Application.Dto.Order;
using ProductManager.Core.Application.Dto.Product;
using ProductManager.Core.Application.Interfaces.Services;
using ProductManager.Core.Application.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] OrderDto orderDto)
        {
            if (orderDto == null)
            {
                return BadRequest("Order data is null");
            }

            await _orderService.Add(orderDto);

            return Ok();
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrder(int id)
        {
            var product = await _orderService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }
    }
}
