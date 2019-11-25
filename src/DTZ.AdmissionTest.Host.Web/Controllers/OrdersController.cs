using DTZ.AdmissionTest.Platform.Entities;
using DTZ.AdmissionTest.Platform.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DTZ.AdmissionTest.Host.Web.Controllers
{
    [Produces("application/json")]
    [Consumes("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrders _orders;

        public OrdersController([FromServices]Orders orders)
        {
            _orders = orders ?? throw new ArgumentNullException(nameof(orders));
        }

        [ProducesResponseType(typeof(IEnumerable<Orders>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        [HttpGet("orders/{userId}")]
        public IActionResult GetOrders([FromRoute]string userId)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(userId))
                    return BadRequest();

                var result = _orders.GetOrders(userId);

                if (!result.Any())
                    return NotFound();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
