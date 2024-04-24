using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class RentACarDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(StaticData.ConnectionString);
        }


        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().ToTable("Cars");
            modelBuilder.Entity<Color>().ToTable("Colors");
            modelBuilder.Entity<Brand>().ToTable("Brands");
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Customer>().ToTable("Customers");
            modelBuilder.Entity<Rental>().ToTable("Rentals");

            modelBuilder.Entity<Car>()
        .Property(c => c.DailyPrice)
        .HasColumnType("decimal(18, 2)");
        }
    }
}
