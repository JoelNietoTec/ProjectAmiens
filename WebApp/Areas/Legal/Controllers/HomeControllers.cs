using Microsoft.AspNetCore.Mvc;

namespace WebApp.Areas.Legal.Controllers
{
    [Area("Legal")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}