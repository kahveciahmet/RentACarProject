using Core.Entities;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class RentACarDB : DbContext
    {
        public RentACarDB(DbContextOptions<RentACarDB> options) : base(options)
        {

        }
        public RentACarDB()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseSqlServer(StaticData.ConnectionString);
        }


        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car { Id = 1, BrandId = 1, ColorId = 3, DailyPrice = 3700, Description = "BMW 520i Sedan 2023 Model", ModelYear = new DateTime(2023, 1, 1), IsActive = true, IsDeleted = false },
                new Car { Id = 2, BrandId = 2, ColorId = 1, DailyPrice = 4200, Description = "Mercedes-Benz GLC180 SUV 2024 Model", ModelYear = new DateTime(2024, 1, 1), IsActive = true, IsDeleted = false },
                new Car { Id = 3, BrandId = 3, ColorId = 4, DailyPrice = 3500, Description = "Volvo S90 Sedan 2022 Model", ModelYear = new DateTime(2022, 1, 1), IsActive = true, IsDeleted = false },
                new Car { Id = 4, BrandId = 4, ColorId = 5, DailyPrice = 6000, Description = "Nissan GT-R R35 2016 Model", ModelYear = new DateTime(2024, 1, 1), IsActive = true, IsDeleted = false }
            );

            modelBuilder.Entity<Color>().HasData(
                new Color { Id = 1, Name = "White", IsActive = true, IsDeleted = false },
                new Color { Id = 2, Name = "Gray", IsActive = true, IsDeleted = false },
                new Color { Id = 3, Name = "Black", IsActive = true, IsDeleted = false },
                new Color { Id = 4, Name = "Red", IsActive = true, IsDeleted = false },
                new Color { Id = 5, Name = "Midnight Purple", IsActive = true, IsDeleted = false }
            );

            modelBuilder.Entity<Brand>().HasData(
                new Brand { Id = 1, Name = "BMW", IsActive = true, IsDeleted = false },
                new Brand { Id = 2, Name = "Mercedes-Benz", IsActive = true, IsDeleted = false },
                new Brand { Id = 3, Name = "Volvo", IsActive = true, IsDeleted = false },
                new Brand { Id = 4, Name = "Nissan", IsActive = true, IsDeleted = false }
            );

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, FirstName = "Ahmet", LastName = "Kahveci", Email = "ahmettkkahveci@gmail.com", /*Password = "123456",*/ IsActive = true, IsDeleted = false },
                new User { Id = 2, FirstName = "Ebru", LastName = "Küçük", Email = "ebrukucuk024@gmail.com", /*Password = "123456",*/ IsActive = true, IsDeleted = false },
                new User { Id = 3, FirstName = "Metin", LastName = "Ata", Email = "metsinpeace@gmail.com", /*Password = "123456",*/ IsActive = true, IsDeleted = false },
                new User { Id = 4, FirstName = "Berkay", LastName = "Çamur", Email = "berkaycamur61@gmail.com", /*Password = "123456",*/ IsActive = true, IsDeleted = false }
            );

            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, UserId = 1, CompanyName = "Ahmet Lojistik", IsActive = true, IsDeleted = false },
                new Customer { Id = 2, UserId = 2, CompanyName = "Ebru Lojistik", IsActive = true, IsDeleted = false },
                new Customer { Id = 3, UserId = 3, CompanyName = "Metin Lojistik", IsActive = true, IsDeleted = false },
                new Customer { Id = 4, UserId = 4, CompanyName = "Berkay Lojistik", IsActive = true, IsDeleted = false }
            );

            modelBuilder.Entity<Rental>().HasData(
                new Rental { Id = 9, CarId = 4, CustomerId = 1, RentDate = new DateTime(2024, 04, 20), ReturnDate = new DateTime(2024, 04, 25), IsActive = true, IsDeleted = false },
                new Rental { Id = 10, CarId = 3, CustomerId = 2, RentDate = new DateTime(2024, 04, 20), ReturnDate = new DateTime(2024, 04, 25), IsActive = true, IsDeleted = false },
                new Rental { Id = 11, CarId = 2, CustomerId = 3, RentDate = new DateTime(2024, 04, 20), ReturnDate = new DateTime(2024, 04, 25), IsActive = true, IsDeleted = false },
                new Rental { Id = 12, CarId = 1, CustomerId = 4, RentDate = new DateTime(2024, 05, 01), ReturnDate = new DateTime(2024, 05, 06), IsActive = true, IsDeleted = false }
            );

            modelBuilder.Entity<Car>()
                .HasOne(c => c.Brand)
                .WithMany()
                .HasForeignKey(c => c.BrandId);

            modelBuilder.Entity<Car>()
                .HasOne(c => c.Color)
                .WithMany()
                .HasForeignKey(c => c.ColorId);

            modelBuilder.Entity<Customer>()
                .HasOne(c => c.User)
                .WithMany()
                .HasForeignKey(c => c.UserId);

            modelBuilder.Entity<Rental>()
                 .HasOne(r => r.Car)
                 .WithMany()
                 .HasForeignKey(r => r.CarId);

            modelBuilder.Entity<Rental>()
                 .HasOne(r => r.Customer)
                 .WithMany()
                 .HasForeignKey(r => r.CustomerId);

            modelBuilder.Entity<Car>()
        .Property(c => c.DailyPrice)
        .HasColumnType("decimal(18, 2)");
        }
    }
}
