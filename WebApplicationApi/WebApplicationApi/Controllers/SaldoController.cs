using Microsoft.AspNetCore.Mvc;
using WebApplicationApi.Models;

namespace WebApplicationApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class SaldoController : ControllerBase
    {
    
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(190);
        }

        [HttpPost]
        [Route("Agregar")]
        public IActionResult AgregarSaldo(double saldo, Saldo saldoDos)
        {
            return Ok(190+saldo);
        }
    }
}