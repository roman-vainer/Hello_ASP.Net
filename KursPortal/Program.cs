using KursPortal.Models;
using Microsoft.EntityFrameworkCore;

namespace KursPortal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //MVC aktivieren
            builder.Services.AddControllersWithViews();

            //DbContext für die Datenbankanbindung registrieren
            builder.Services.AddDbContext<KursPortalDBContext>(
                opts => opts.UseSqlServer(builder.Configuration.GetConnectionString("KursDB")));

            var app = builder.Build();

            //Statische Datei freischalten (z.b. Bootstrap-Bibliothek)
            app.UseStaticFiles();

            //Standartroute für Navigation festlegen
            //Erst Controller, dann dazugehörige Action
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            //Aufruf der Migrate-methode zum automatischen Ausführen der Migrtaionen beim Starten der Anwendung
            EnsureDatabase.Migrate(app);

            app.Run();
        }
    }
}
