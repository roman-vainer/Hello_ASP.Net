using Microsoft.AspNetCore.Mvc;
using KursPortal.Models;

namespace KursPortal.Controllers
{
    public class KursController : Controller
    {
        private KursPortalDBContext ctx;
        public KursController(KursPortalDBContext ctx)
        {
            this.ctx = ctx;
        }
        public IActionResult Index()
        {

            return View(ctx.Kurse);
        }

        public IActionResult Detail(int id)
        {
            var kurs = ctx.Kurse.FirstOrDefault(k => k.Id == id);
            return View(kurs);
        }
    }
}
