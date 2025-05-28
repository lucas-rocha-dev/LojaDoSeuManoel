using Microsoft.AspNetCore.Mvc;

namespace LojaDoSeuManoel.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
            return "Deu certo!";

        }
    }
}
