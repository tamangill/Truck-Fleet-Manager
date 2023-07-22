using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Truck_Fleet_Manager.Model;

namespace Truck_Fleet_Manager.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Truck> Trucks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the one-to-one relationship between Driver and Truck
            modelBuilder.Entity<Driver>()
                .HasOne(d => d.Truck)
                .WithOne(t => t.Driver)
                .HasForeignKey<Truck>(t => t.DriverId); // Assuming DriverId is the foreign key property in the Truck entity
        }
    }
}
