using Microsoft.AspNetCore.Mvc;

namespace WebApp.Areas.Customers.Controllers
{
    [Area("Customers")]
    public class ClientsController : Controller
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