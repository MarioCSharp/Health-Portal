using Health.Models.Health;
using Microsoft.AspNetCore.Mvc;

namespace Health.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Topics()
        {
            return View();
        }
    }
}
