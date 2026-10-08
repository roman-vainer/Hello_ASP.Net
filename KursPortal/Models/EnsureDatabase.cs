using Microsoft.EntityFrameworkCore;
namespace KursPortal.Models
{
    public static class EnsureDatabase
    {
        public static void Migrate(IApplicationBuilder app)
        {
            KursPortalDBContext ctx = app.ApplicationServices
                .CreateScope()
                .ServiceProvider
                .GetRequiredService<KursPortalDBContext>();

            if(ctx.Database.GetPendingMigrations().Any())
            {
                ctx.Database.Migrate();
            }
        }
    }
}
