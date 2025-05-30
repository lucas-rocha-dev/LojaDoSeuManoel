using LojaDoSeuManoel.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LojaDoSeuManoel.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class BoxesController : ControllerBase
    {
        private readonly IBoxRepository _boxRepository;

        public BoxesController(IBoxRepository boxRepository)
        {
            _boxRepository = boxRepository;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var boxes = await _boxRepository.GetAllAsync();
            return Ok(boxes);
        }
    }
}
