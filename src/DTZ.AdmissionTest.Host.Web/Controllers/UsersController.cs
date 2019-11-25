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
    public class UsersController : ControllerBase
    {
        private readonly IUsers _users;

        public UsersController([FromServices]Users users)
        {
            _users = users ?? throw new ArgumentNullException(nameof(users));
        }

        [ProducesResponseType(typeof(IEnumerable<Users>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var result = _users.Get();

                if (!result.Any())
                    return NotFound();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [ProducesResponseType(201)]
        [ProducesResponseType(500)]
        [HttpPost]
        public IActionResult CreateUser([FromBody]Users user)
        {
            try
            {
                var result = _users.Create(user);

                return Created("users", null);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [ProducesResponseType(201)]
        [ProducesResponseType(500)]
        [HttpPut("users/{id}")]
        public IActionResult UpdateUser([FromRoute]string id, [FromBody]Users user)
        {
            try
            {
                var result = _users.Update(id, user);

                return Accepted("users/{id}", null);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [ProducesResponseType(201)]
        [ProducesResponseType(500)]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
