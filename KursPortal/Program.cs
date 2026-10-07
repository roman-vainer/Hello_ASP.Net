namespace KursPortal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //MVC aktivieren
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            //Statische Datei freischalten (z.b. Bootstrap-Bibliothek)
            app.UseStaticFiles();

            //Standartroute für Navigation festlegen
            //Erst Controller, dann dazugehörige Action
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
