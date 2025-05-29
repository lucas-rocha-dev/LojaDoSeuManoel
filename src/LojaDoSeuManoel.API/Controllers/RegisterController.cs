using LojaDoSeuManoel.Application.DTOs.Request;
using LojaDoSeuManoel.Application.Services;
using Microsoft.AspNetCore.Mvc;


namespace LojaDoSeuManoel.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegisterController : ControllerBase
    {
        private readonly IAuthService _authService;

        public RegisterController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            
            var token = _authService.GerarTokenJWT();
            return Ok(new { token });


           // return Unauthorized();
        }
    }



}
