using Microsoft.EntityFrameworkCore;
using Model;

namespace Data
{
    public class NewshoreDbContext : DbContext
    {
        public NewshoreDbContext(DbContextOptions<NewshoreDbContext> options) : base(options)
        {

        }

        public DbSet<Flight> Flights { get; set; }
        public DbSet<Transport> Transports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
