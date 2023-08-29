using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationApi.DTOs;
using WebApplicationApi.Models;

namespace WebApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        [Route("Login")]
        public IActionResult Get(LoginDto login)
        {
            if(login.Nombre=="Pablo" && login.Clave == "123")
            {
                return Ok(210);
            }
            return Unauthorized("User invalid");
        }

        [HttpPost]
        [Route("LoginPrueba")]
        public IActionResult GetDos(Login login)
        {
            if (login.Nombre == "Pablo" && login.Clave == "123")
            {
                return Ok(210);
            }
            return Unauthorized("User invalid");
        }

        [HttpPut]
        public IActionResult EditarLogin(int id)
        {
            return Ok($"se elimino {id}");
        }
    }
}
