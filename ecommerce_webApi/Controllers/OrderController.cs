using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommerce_app.DTOs.Order;
using Microsoft.AspNetCore.Mvc;
using ecommerce_app.Services;
using ecommerce_app.Entities;


namespace ecommerce_app.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly OrderService _orderService;

        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                Order createdOrder = await _orderService.CreateOrderAsync(dto);
                return Ok(createdOrder);
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpGet("{customerId}")]
        public async Task<ActionResult<List<OrderLoadDto>>> GetOrders(string customerId)
        {
            var result = await _orderService.LoadOrderService(customerId);
            return Ok(result);
        }


    }
}