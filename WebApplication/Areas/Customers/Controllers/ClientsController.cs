using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Areas.Customers.Controllers
{
    public class ClientsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}