using Microsoft.AspNetCore.Mvc;
using KursPortal.Models;

namespace KursPortal.Controllers
{
    public class KursController : Controller
    {
        List<Kurs> kurse = new()
            {
                new Kurs
                {
                    Id = 1,
                    Kursname = "C# Grundlagen",
                    Dozent = "Max Mustermann",
                    AnzahlTeilnehmer = 20,
                    DauerInTagen = 5,
                    inhalt = "Einführung in die Programmierung mit C#"
                },
                new Kurs
                {
                    Id = 2,
                    Kursname = "ASP.NET Core",
                    Dozent = "Erika Musterfrau",
                    AnzahlTeilnehmer = 15,
                    DauerInTagen = 7,
                    inhalt = "Entwicklung von Webanwendungen mit ASP.NET Core"
                },
                new Kurs
                {
                    Id = 3,
                    Kursname = "Entity Framework Core",
                    Dozent = "John Doe",
                    AnzahlTeilnehmer = 10,
                    DauerInTagen = 3,
                    inhalt = "Arbeiten mit Datenbanken und ORM"
                }
            };
        public IActionResult Index()
        {
            return View(kurse);
        }

        public IActionResult Detail(int id)
        {
            var kurs = kurse.FirstOrDefault(k => k.Id == id);
            return View(kurs);
        }
    }
}
