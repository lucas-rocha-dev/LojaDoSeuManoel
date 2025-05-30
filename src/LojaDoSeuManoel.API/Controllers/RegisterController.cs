using LojaDoSeuManoel.Application.DTOs.Request;
using LojaDoSeuManoel.Application.Services;
using LojaDoSeuManoel.Application.Validator;
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
        public IActionResult Login([FromBody] RequestUserRegister request)
        {
            var validator = new RegisterValidator();
            var isValid = validator.Validate(request);

            if(isValid.IsValid == false)
            {
                return BadRequest(isValid.Errors.Select(e => e.ErrorMessage));
            }
            var token = _authService.GerarTokenJWT();
            return Ok(new { token });

        }
    }



}
