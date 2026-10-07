using Microsoft.AspNetCore.Mvc;

namespace KursPortal.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
