using Microsoft.AspNetCore.Mvc;

namespace Costdle.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
