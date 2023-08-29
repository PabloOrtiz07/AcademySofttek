using Microsoft.AspNetCore.Mvc;

namespace WebApplicationApi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
