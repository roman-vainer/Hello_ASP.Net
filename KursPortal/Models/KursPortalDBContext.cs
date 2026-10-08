using Microsoft.EntityFrameworkCore;
namespace KursPortal.Models
{
    public class KursPortalDBContext : DbContext
    {

        public KursPortalDBContext(DbContextOptions<KursPortalDBContext> opts) : base(opts) { }

        public DbSet<Kurs> Kurse { get; set; }
    }
}
