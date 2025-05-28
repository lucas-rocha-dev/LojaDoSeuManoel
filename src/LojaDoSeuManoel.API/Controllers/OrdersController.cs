using LojaDoSeuManoel.Application.DTOs.Request;
using LojaDoSeuManoel.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LojaDoSeuManoel.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IEmpacotadorService _service;

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RequestOrderDto orderDtos)
        {

            var response = await _service.ProcessarPedidosAsync(orderDtos);
            return Ok(response);
        }
    }
}
