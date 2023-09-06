using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationApi.Entities;

namespace WebApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        public UsuariosController() { }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetAll()
        {
            // Implement logic to retrieve all Usuario entities from the repository
            var usuarios = await _GetAll();
            return Ok(usuarios); // Return the list of Usuario entities as an HTTP response
        }
    }
}
