using LojaDoSeuManoel.Application.DTOs.Request;
using LojaDoSeuManoel.Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace LojaDoSeuManoel.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            if (request.Usuario == "admin" && request.Senha == "123456") {
                var token = _authService.GerarTokenJWT();
                return Ok(new { token });
            }

            return Unauthorized();
        }
    }



}
