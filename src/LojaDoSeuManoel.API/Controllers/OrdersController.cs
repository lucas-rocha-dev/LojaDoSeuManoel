using LojaDoSeuManoel.Application.DTO;
using LojaDoSeuManoel.Application.DTOs.Request;
using Microsoft.AspNetCore.Mvc;

namespace LojaDoSeuManoel.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RequestOrderDto orderDtos)
        {
            return Ok("Deu certo!");
        }
    }
}
