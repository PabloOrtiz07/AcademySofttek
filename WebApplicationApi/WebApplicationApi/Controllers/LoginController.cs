using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationApi.DTOs;
using WebApplicationApi.Models;

namespace WebApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LoginController : ControllerBase
    {

       /// <summary>
       /// 
       /// </summary>
       /// <param name="login"></param>
       /// <returns></returns>
       /// 
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
        [AllowAnonymous]
        public IActionResult Users (LoginDto login)
        {
            try
            {
                //throw new NotImplementedException();
                if (login.Clave == "123")
                {
                    return Ok(210);
                }
                return Unauthorized("User invalid");
            }
            catch (Exception ex)
            {
                return BadRequest(400);
            }
    
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
