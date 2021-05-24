using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace Data
{
    public class NewshoreDbContext : DbContext
    {
        public NewshoreDbContext(DbContextOptions<NewshoreDbContext> options) : base(options)
        {

        }

        public DbSet<Flight> Flights { get; set; }
        public DbSet<Transport> Transports { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Flight>().HasOne(p => p.Transport);

            modelBuilder.Entity<Passenger>()
                .HasData(
                new Passenger
                {
                    Id = 1,
                    Mail = "jperez@gmail.com",
                    Name = "Juan Perez",
                    Number = 5493416335598
                },
                new Passenger
                {
                    Id = 2,
                    Mail = "mgarcia@gmail.com",
                    Number = 5493415887744,
                    Name = "Manuel Garcia"
                },
                new Passenger
                {
                    Id = 3,
                    Mail = "alberto@gmail.com",
                    Number = 5493415847744,
                    Name = "Alberto Perez"
                });
        }
    }
}
