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

            return View(ctx.Kurse.ToList());
        }

        public IActionResult Detail(int id)
        {
            var kurs = ctx.Kurse.FirstOrDefault(k => k.Id == id);
            return View(kurs);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Kurs kurs)
        {
            if (ModelState.IsValid)
            {
                ctx.Kurse.Add(kurs);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kurs);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var kurs = ctx.Kurse.FirstOrDefault(k => k.Id == id);
            return View(kurs);
        }

        [HttpPost]
        public IActionResult Edit(Kurs kurs)
        {
            if (ModelState.IsValid)
            {
                var kursDB = ctx.Kurse.FirstOrDefault(k => k.Id == kurs.Id);

                if (kursDB != null)
                {
                    kursDB.Kursname = kurs.Kursname;
                    kursDB.Dozent = kurs.Dozent;
                    kursDB.AnzahlTeilnehmer = kurs.AnzahlTeilnehmer;
                    kursDB.DauerInTagen = kurs.DauerInTagen;
                    kursDB.Inhalt = kurs.Inhalt;
                    ctx.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(kurs);
        }

       
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var kurs = ctx.Kurse.FirstOrDefault(k => k.Id == id);
            if (kurs != null)
            {
                ctx.Kurse.Remove(kurs);
                ctx.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
