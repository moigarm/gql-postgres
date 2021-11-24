using Microsoft.EntityFrameworkCore;

namespace API
{
    public class ElDbContext : DbContext
    {
        public ElDbContext(DbContextOptions<ElDbContext> options) : base(options)
        {

        }
        public DbSet<Entidad> Entidades { get; set; }
    }
}
