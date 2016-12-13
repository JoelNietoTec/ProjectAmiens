using Microsoft.AspNetCore.Mvc;

namespace WebApp.Areas.Legal.Controllers
{
    [Area("Legal")]
    public class PositionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult New()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        } 
    }
}