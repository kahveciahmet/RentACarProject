using Core.Entities;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class RentACarDB : DbContext
    {
        #region PasswordInformations
        private static readonly byte[] ahmetPasswordHash = new byte[] { 0xAF, 0xC6, 0x2F, 0xE3, 0xD3, 0x67, 0x34, 0x40, 0x1F, 0x28, 0x2C, 0x71, 0xD6, 0x79, 0xE4, 0xA3, 0x96, 0x17, 0xE5, 0x39, 0xBB, 0x2E, 0x3C, 0x86, 0x59, 0x0C, 0x9B, 0xA0, 0x5F, 0xF3, 0xAE, 0x59, 0xE8, 0x96, 0xA8, 0x4C, 0x90, 0xBD, 0x51, 0xAE, 0x8F, 0xAA, 0xD9, 0x0D, 0xB7, 0x5C, 0x27, 0xEB, 0x80, 0xD9, 0x5B, 0x1F, 0x91, 0x47, 0xDF, 0x26, 0xAA, 0x83, 0x34, 0x58, 0x26, 0x1C, 0x37, 0x41 };
        private static readonly byte[] ahmetPasswordSalt = new byte[] { 0xDD, 0x27, 0x84, 0x8D, 0x57, 0xC5, 0x35, 0xB2, 0xEA, 0xC0, 0x6F, 0x68, 0xD5, 0x88, 0xC6, 0xF1, 0x5B, 0x8B, 0x56, 0xFD, 0x5A, 0x50, 0x2F, 0x2F, 0x96, 0xD2, 0xCC, 0x3D, 0xF4, 0xB3, 0xC4, 0xE6, 0x0F, 0xAE, 0x01, 0x2F, 0x78, 0x58, 0x9F, 0xCA, 0xC1, 0x04, 0x82, 0xA0, 0x48, 0x5F, 0xB0, 0x32, 0x02, 0xDB, 0x8E, 0x59, 0xB6, 0x39, 0x18, 0xFC, 0x50, 0x95, 0x2A, 0x87, 0x3E, 0x48, 0xCC, 0x33, 0x01, 0x2F, 0x02, 0xE8, 0x39, 0x30, 0x77, 0xBF, 0x7E, 0xA5, 0x98, 0xD6, 0xF3, 0x6F, 0xF1, 0xFC, 0xE9, 0xEB, 0x50, 0x18, 0x35, 0x29, 0xB1, 0xFE, 0x94, 0x74, 0xC6, 0x90, 0x98, 0x9A, 0x3D, 0x35, 0xCA, 0x89, 0xBE, 0xAB, 0xD7, 0xE6, 0xC4, 0xEF, 0x69, 0xBD, 0xCF, 0xEC, 0xB9, 0x3F, 0xB5, 0x1E, 0xD9, 0xA7, 0x02, 0x87, 0x49, 0xCE, 0xA9, 0xAF, 0x87, 0x3E, 0x45, 0xE0, 0x04, 0x85, 0x09, 0xC7 };
        private static readonly byte[] ebruPasswordHash = new byte[] { 0x2F, 0x9E, 0x13, 0xFB, 0x40, 0x46, 0xA6, 0xA4, 0x99, 0x3D, 0x14, 0xC1, 0xEA, 0x00, 0xD5, 0x7F, 0x79, 0xE2, 0x8C, 0x83, 0x46, 0x5A, 0xB8, 0x74, 0xE1, 0x3B, 0x7A, 0xF9, 0x93, 0x02, 0x61, 0x09, 0xDA, 0xB6, 0x50, 0x29, 0xE7, 0x88, 0x2F, 0x2E, 0xA3, 0x7E, 0xC5, 0xAA, 0xB6, 0x22, 0xFC, 0xC9, 0xDF, 0xE2, 0x74, 0x31, 0x4A, 0x22, 0x62, 0xAD, 0x2E, 0x29, 0x67, 0xE5, 0x59, 0xC9, 0x48, 0xCA };
        private static readonly byte[] ebruPasswordSalt = new byte[] { 0x29, 0x36, 0xE7, 0x26, 0x98, 0xD2, 0x88, 0xE4, 0xA6, 0xC4, 0x4B, 0xFC, 0x4D, 0xD8, 0xB1, 0x12, 0x61, 0xDE, 0xF5, 0xF4, 0xFF, 0x6C, 0xBF, 0x0E, 0xC3, 0x32, 0x57, 0x2D, 0xEB, 0x68, 0x6D, 0x31, 0x91, 0x22, 0x75, 0x0F, 0x93, 0x6A, 0x6D, 0xA7, 0xC7, 0x59, 0x1A, 0x6D, 0x7F, 0x53, 0xC5, 0xAC, 0x8A, 0x63, 0x33, 0xD2, 0xD4, 0xB7, 0x99, 0x8A, 0x42, 0x9D, 0x3C, 0x17, 0x66, 0x01, 0x8F, 0x8B, 0x9F, 0x4A, 0xBA, 0xBC, 0x1E, 0x3D, 0xFB, 0xA5, 0x6F, 0x0B, 0x98, 0x93, 0xC6, 0xD1, 0x93, 0xDE, 0xB0, 0xF1, 0xA5, 0x76, 0x31, 0x26, 0x7C, 0x2E, 0x11, 0xA4, 0x4F, 0x90, 0x20, 0xC4, 0xDB, 0x8B, 0x4E, 0xF4, 0x31, 0x9C, 0x84, 0x96, 0x88, 0x17, 0x58, 0x6B, 0x6F, 0x61, 0xBC, 0x36, 0xA7, 0x2E, 0x75, 0x89, 0xA7, 0x06, 0x5E, 0x3E, 0x8B, 0x50, 0xA4, 0x0A, 0xA9, 0x26, 0x02, 0xF9, 0xDF, 0xFE, 0x0 };
        private static readonly byte[] metinPasswordHash = new byte[] { 0x22, 0x02, 0x61, 0xFB, 0x03, 0xD2, 0x9F, 0x2C, 0x74, 0x51, 0xB7, 0x3A, 0x82, 0xB5, 0xAA, 0x0E, 0x50, 0xFA, 0x06, 0x42, 0xFC, 0x17, 0xB3, 0xE7, 0x3C, 0x61, 0x68, 0x27, 0xA6, 0xCE, 0xBD, 0x47, 0xB0, 0xF0, 0x67, 0xCD, 0xE5, 0x9B, 0x64, 0xFC, 0x18, 0x43, 0x8B, 0x07, 0x1E, 0x2B, 0xDA, 0xFA, 0xCF, 0xAC, 0x29, 0xAB, 0xF4, 0x38, 0x03, 0xE1, 0x9E, 0x28, 0xAB, 0xE8, 0x6A, 0x84, 0x16, 0x07, 0x6C, 0x9 };
        private static readonly byte[] metinPasswordSalt = new byte[] { 0x3A, 0x81, 0x29, 0x8E, 0x56, 0x3B, 0x21, 0x45, 0x5A, 0x5F, 0xC4, 0x9C, 0x43, 0x9F, 0x0B, 0x53, 0x11, 0xCB, 0x33, 0xFC, 0x0B, 0x17, 0x0E, 0x3A, 0x70, 0x70, 0x04, 0xFA, 0x47, 0x1E, 0x94, 0x49, 0xB3, 0x03, 0xBB, 0x36, 0x5F, 0x20, 0x58, 0xAA, 0xD7, 0xDC, 0xB3, 0x6A, 0x7F, 0xD5, 0x26, 0x22, 0x1B, 0xBF, 0xF8, 0x81, 0xBF, 0x6C, 0x70, 0x5C, 0xFB, 0x1C, 0x70, 0x5C, 0xFB, 0x1C, 0xDA, 0xE5, 0x6A, 0xED, 0x0E, 0x88, 0x25, 0x0A, 0xC5, 0x6D, 0x56, 0xD5, 0x6E, 0x34, 0x8D, 0x73, 0x59, 0xA1, 0x73, 0xEF, 0x80, 0x0E, 0x84, 0x06, 0xE0, 0x85, 0xB0, 0x21, 0x0D, 0xAA, 0xF0, 0x76, 0x05, 0x68, 0xA7, 0xDA, 0x8D, 0x56, 0x4A, 0x10, 0x07, 0x53, 0x01, 0xEE, 0xF3, 0xB0, 0x1C, 0xF5, 0xD6, 0x08, 0xB5, 0x23, 0xF2, 0xF8, 0x59, 0x70, 0xE7, 0xCA, 0x87, 0xAD, 0x58, 0xA4, 0xB8, 0x06, 0x97, 0x8A, 0xE2, 0x97, 0x78, 0x3D, 0x99, 0x1 };
        private static readonly byte[] berkayPasswordHash = new byte[] { 0xDB, 0x55, 0x18, 0x44, 0x01, 0xCE, 0x15, 0xAF, 0xFB, 0x08, 0x35, 0xEF, 0x3F, 0x23, 0xF3, 0x12, 0xE4, 0x12, 0xEE, 0x5E, 0xEB, 0x44, 0x09, 0x6D, 0x1C, 0xB9, 0x04, 0xE4, 0x75, 0x4C, 0x4D, 0x9F, 0xB0, 0x9B, 0xE4, 0x6B, 0xB4, 0x76, 0x4E, 0x3B, 0xA2, 0x43, 0xF5, 0x78, 0x69, 0x2C, 0x11, 0x64, 0xF6, 0xEB, 0x86, 0xF8, 0x2B, 0x9C, 0xC9, 0xE2, 0xC4, 0x2A, 0xB0, 0x93, 0x28, 0xEC, 0x08, 0x42 };
        private static readonly byte[] berkayPasswordSalt = new byte[] { 0x88, 0x59, 0x0A, 0x43, 0x3C, 0x23, 0x2B, 0x17, 0xEC, 0xDF, 0x84, 0x7F, 0x69, 0x70, 0xD8, 0x83, 0xAB, 0xF4, 0x94, 0x19, 0x67, 0xDB, 0x87, 0xB1, 0x9E, 0x12, 0xF7, 0x8C, 0xF5, 0x7B, 0xD6, 0x27, 0x21, 0xF3, 0x99, 0x45, 0xDC, 0xA6, 0x52, 0x16, 0x31, 0x7F, 0x5E, 0x67, 0x01, 0x64, 0xB9, 0xF7, 0x88, 0x81, 0xAB, 0x3D, 0x9F, 0x06, 0xAA, 0x45, 0xEF, 0x52, 0x7F, 0xE8, 0x8D, 0xC7, 0x03, 0x8A, 0x9C, 0xC5, 0xF8, 0xB4, 0x68, 0x51, 0xB4, 0x80, 0x97, 0xBB, 0x97, 0xDA, 0x2A, 0x17, 0xB0, 0xE3, 0xE8, 0x5D, 0x2F, 0xAE, 0x5B, 0xFD, 0x5D, 0x06, 0x99, 0xE6, 0xC0, 0x34, 0x38, 0xB5, 0x44, 0x7D, 0x47, 0x14, 0x2D, 0x38, 0x06, 0x2D, 0x53, 0xD9, 0xE8, 0xE4, 0x27, 0x15, 0x7C, 0x22, 0xDB, 0x29, 0x03, 0x37, 0xE0, 0xEF, 0xEE, 0x6E, 0x72, 0xF4, 0x18, 0xF4, 0xCB, 0xA1, 0x77, 0xC0, 0xFA, 0xD1 };
        #endregion
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
                new Car { Id = 1, BrandId = 1, ColorId = 3, ColorName = "Black", ModelYear = 2023, Description = "BMW 520i Sedan 2023 Model", BrandName = "BMW", IsActive = true, IsDeleted = false, DailyPrice = 1500, TransmissionType = "Automatic" },
                new Car { Id = 2, BrandId = 2, ColorId = 2, ColorName = "White", ModelYear = 2024, Description = "Mercedes-Benz GLC180 SUV 2024 Model", BrandName = "Mercedes-Benz", IsActive = true, IsDeleted = false, DailyPrice = 2000, TransmissionType = "Automatic" },
                new Car { Id = 3, BrandId = 3, ColorId = 4, ColorName = "Red", ModelYear = 2022, Description = "Volvo S90 Sedan 2022 Model", BrandName = "Volvo", IsActive = true, IsDeleted = false, DailyPrice = 1800, TransmissionType = "Automatic" },
                new Car { Id = 4, BrandId = 4, ColorId = 5, ColorName = "Midnight Purple", ModelYear = 2024, Description = "Nissan GT-R R35 2016 Model", BrandName = "Nissan", IsActive = true, IsDeleted = false, DailyPrice = 2500, TransmissionType = "Automatic" },
                new Car { Id = 5, BrandId = 5, ColorId = 1, ColorName = "White", ModelYear = 2023, Description = "Toyota Corolla 2023 Model", BrandName = "Toyota", IsActive = true, IsDeleted = false, DailyPrice = 1200, TransmissionType = "Manual" },
                new Car { Id = 6, BrandId = 6, ColorId = 2, ColorName = "Gray", ModelYear = 2021, Description = "Honda Civic 2021 Model", BrandName = "Honda", IsActive = true, IsDeleted = false, DailyPrice = 1300, TransmissionType = "Automatic" },
                new Car { Id = 7, BrandId = 7, ColorId = 3, ColorName = "Black", ModelYear = 2020, Description = "Ford Focus 2020 Model", BrandName = "Ford", IsActive = true, IsDeleted = false, DailyPrice = 1400, TransmissionType = "Manual" },
                new Car { Id = 8, BrandId = 8, ColorId = 4, ColorName = "Red", ModelYear = 2019, Description = "Chevrolet Malibu 2019 Model", BrandName = "Chevrolet", IsActive = true, IsDeleted = false, DailyPrice = 1600, TransmissionType = "Automatic" },
                new Car { Id = 9, BrandId = 1, ColorId = 5, ColorName = "Midnight Purple", ModelYear = 2018, Description = "BMW 320i 2018 Model", BrandName = "BMW", IsActive = true, IsDeleted = false, DailyPrice = 1500, TransmissionType = "Automatic" },
                new Car { Id = 10, BrandId = 2, ColorId = 1, ColorName = "White", ModelYear = 2017, Description = "Mercedes-Benz C180 2017 Model", BrandName = "Mercedes-Benz", IsActive = true, IsDeleted = false, DailyPrice = 1400, TransmissionType = "Automatic" },
                new Car { Id = 11, BrandId = 3, ColorId = 2, ColorName = "Gray", ModelYear = 2016, Description = "Volvo XC60 2016 Model", BrandName = "Volvo", IsActive = true, IsDeleted = false, DailyPrice = 1300, TransmissionType = "Automatic" },
                new Car { Id = 12, BrandId = 4, ColorId = 3, ColorName = "Black", ModelYear = 2015, Description = "Nissan Altima 2015 Model", BrandName = "Nissan", IsActive = true, IsDeleted = false, DailyPrice = 1200, TransmissionType = "Manual" },
                new Car { Id = 13, BrandId = 5, ColorId = 4, ColorName = "Red", ModelYear = 2014, Description = "Toyota Camry 2014 Model", BrandName = "Toyota", IsActive = true, IsDeleted = false, DailyPrice = 1300, TransmissionType = "Automatic" },
                new Car { Id = 14, BrandId = 6, ColorId = 5, ColorName = "Midnight Purple", ModelYear = 2013, Description = "Honda Accord 2013 Model", BrandName = "Honda", IsActive = true, IsDeleted = false, DailyPrice = 1100, TransmissionType = "Manual" },
                new Car { Id = 15, BrandId = 7, ColorId = 1, ColorName = "White", ModelYear = 2012, Description = "Ford Mustang 2012 Model", BrandName = "Ford", IsActive = true, IsDeleted = false, DailyPrice = 1400, TransmissionType = "Manual" },
                new Car { Id = 16, BrandId = 8, ColorId = 2, ColorName = "Gray", ModelYear = 2011, Description = "Chevrolet Cruze 2011 Model", BrandName = "Chevrolet", IsActive = true, IsDeleted = false, DailyPrice = 1200, TransmissionType = "Automatic" },
                new Car { Id = 17, BrandId = 1, ColorId = 3, ColorName = "Black", ModelYear = 2010, Description = "BMW X5 2010 Model", BrandName = "BMW", IsActive = true, IsDeleted = false, DailyPrice = 1500, TransmissionType = "Automatic" },
                new Car { Id = 18, BrandId = 2, ColorId = 4, ColorName = "Red", ModelYear = 2009, Description = "Mercedes-Benz E200 2009 Model", BrandName = "Mercedes-Benz", IsActive = true, IsDeleted = false, DailyPrice = 1400, TransmissionType = "Automatic" },
                new Car { Id = 19, BrandId = 3, ColorId = 5, ColorName = "Midnight Purple", ModelYear = 2008, Description = "Volvo V60 2008 Model", BrandName = "Volvo", IsActive = true, IsDeleted = false, DailyPrice = 1300, TransmissionType = "Automatic" },
                new Car { Id = 20, BrandId = 4, ColorId = 1, ColorName = "White", ModelYear = 2007, Description = "Nissan Sentra 2007 Model", BrandName = "Nissan", IsActive = true, IsDeleted = false, DailyPrice = 1100, TransmissionType = "Manual" }
            );


            modelBuilder.Entity<Color>().HasData(
                new Color { Id = 1, Name = "White", IsActive = true, IsDeleted = false },
                new Color { Id = 2, Name = "Gray", IsActive = true, IsDeleted = false },
                new Color { Id = 3, Name = "Black", IsActive = true, IsDeleted = false },
                new Color { Id = 4, Name = "Red", IsActive = true, IsDeleted = false },
                new Color { Id = 5, Name = "Midnight Purple", IsActive = true, IsDeleted = false },
                new Color { Id = 6, Name = "Blue", IsActive = true, IsDeleted = false }
            );

            modelBuilder.Entity<Brand>().HasData(
                new Brand { Id = 1, Name = "BMW", IsActive = true, IsDeleted = false },
                new Brand { Id = 2, Name = "Mercedes-Benz", IsActive = true, IsDeleted = false },
                new Brand { Id = 3, Name = "Volvo", IsActive = true, IsDeleted = false },
                new Brand { Id = 4, Name = "Nissan", IsActive = true, IsDeleted = false },
                new Brand { Id = 5, Name = "Toyota", IsActive = true, IsDeleted = false },
                new Brand { Id = 6, Name = "Honda", IsActive = true, IsDeleted = false },
                new Brand { Id = 7, Name = "Ford", IsActive = true, IsDeleted = false },
                new Brand { Id = 8, Name = "Chevrolet", IsActive = true, IsDeleted = false }
            );

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, FirstName = "Ahmet", LastName = "Kahveci", Email = "ahmettkkahveci@gmail.com", PasswordHash = ahmetPasswordHash, PasswordSalt = ahmetPasswordSalt, Status = true, IsActive = true, IsDeleted = false },
                new User { Id = 2, FirstName = "Ebru", LastName = "Küçük", Email = "ebrukucuk024@gmail.com", PasswordHash = ebruPasswordHash, PasswordSalt = ebruPasswordSalt, IsActive = true, IsDeleted = false },
                new User { Id = 3, FirstName = "Metin", LastName = "Ata", Email = "metsinpeace@gmail.com", PasswordHash = metinPasswordHash, PasswordSalt = metinPasswordSalt, IsActive = true, IsDeleted = false },
                new User { Id = 4, FirstName = "Berkay", LastName = "Çamur", Email = "berkaycamur61@gmail.com", PasswordHash = berkayPasswordHash, PasswordSalt = berkayPasswordSalt, IsActive = true, IsDeleted = false }
            );

            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, UserId = 1, CompanyName = "Ahmet Lojistik",UserName = "Ahmet Kahveci", IsActive = true, IsDeleted = false },
                new Customer { Id = 2, UserId = 2, CompanyName = "Ebru Lojistik", UserName = "Ebru Küçük",IsActive = true, IsDeleted = false },
                new Customer { Id = 3, UserId = 3, CompanyName = "Metin Lojistik", UserName = "Metin Ata",IsActive = true, IsDeleted = false },
                new Customer { Id = 4, UserId = 4, CompanyName = "Berkay Lojistik", UserName = "Berkay Çamur",IsActive = true, IsDeleted = false }
            );

            modelBuilder.Entity<Rental>().HasData(
                new Rental { Id = 9, CarId = 4,CarName = "Nissan GT-R R35 2016 Model", CustomerId = 1,CustomerName = "Ahmet Lojistik", RentDate = new DateTime(2024, 04, 20), ReturnDate = new DateTime(2024, 04, 25), IsActive = true, IsDeleted = false },
                new Rental { Id = 10, CarId = 3, CarName = "Volvo S90 Sedan 2022 Model", CustomerId = 2, CustomerName = "Ebru Lojistik", RentDate = new DateTime(2024, 04, 20), ReturnDate = new DateTime(2024, 04, 25), IsActive = true, IsDeleted = false },
                new Rental { Id = 11, CarId = 2, CarName = "Mercedes-Benz GLC180 SUV 2024 Model", CustomerId = 3, CustomerName = "Metin Lojistik", RentDate = new DateTime(2024, 04, 20), ReturnDate = new DateTime(2024, 04, 25), IsActive = true, IsDeleted = false },
                new Rental { Id = 12, CarId = 1, CarName = "BMW 520i Sedan 2023 Model", CustomerId = 4, CustomerName = "Berkay Lojistik", RentDate = new DateTime(2024, 05, 01), ReturnDate = new DateTime(2024, 05, 06), IsActive = true, IsDeleted = false }
            );

            #region OperationClaimDatas
            modelBuilder.Entity<OperationClaim>().HasData(
                new OperationClaim { Id = 1, Name = "admin"},
                new OperationClaim { Id = 2, Name = "moderator"},
                new OperationClaim { Id = 3, Name = "user"},
                new OperationClaim { Id = 4, Name = "car.add"},
                new OperationClaim { Id = 5, Name = "car.delete"},
                new OperationClaim { Id = 6, Name = "car.update"},
                new OperationClaim { Id = 7, Name = "brand.add"},
                new OperationClaim { Id = 8, Name = "brand.delete"},
                new OperationClaim { Id = 9, Name = "brand.update"},
                new OperationClaim { Id = 10, Name = "color.add"},
                new OperationClaim { Id = 11, Name = "color.delete"},
                new OperationClaim { Id = 12, Name = "color.update"},
                new OperationClaim { Id = 13, Name = "rental.add"},
                new OperationClaim { Id = 14, Name = "rental.delete"},
                new OperationClaim { Id = 15, Name = "rental.update"},
                new OperationClaim { Id = 16, Name = "carimage.add"},
                new OperationClaim { Id = 17, Name = "carimage.delete"},
                new OperationClaim { Id = 18, Name = "carimage.update"},
                new OperationClaim { Id = 19, Name = "user.add"},
                new OperationClaim { Id = 20, Name = "user.delete"},
                new OperationClaim { Id = 21, Name = "user.update"},
                new OperationClaim { Id = 22, Name = "customer.add"},
                new OperationClaim { Id = 23, Name = "customer.delete"},
                new OperationClaim { Id = 24, Name = "customer.update"}
                );

            modelBuilder.Entity<UserOperationClaim>().HasData(
                new UserOperationClaim {Id = 1, UserId = 1 ,OperationClaimId = 1},
                new UserOperationClaim {Id = 2, UserId = 1 ,OperationClaimId = 4},
                new UserOperationClaim {Id = 3, UserId = 1 ,OperationClaimId = 5},
                new UserOperationClaim {Id = 4, UserId = 1 ,OperationClaimId = 6},
                new UserOperationClaim {Id = 5, UserId = 2 ,OperationClaimId = 3},
                new UserOperationClaim {Id = 6, UserId = 3 ,OperationClaimId = 3},
                new UserOperationClaim {Id = 7, UserId = 4 ,OperationClaimId = 3},
                new UserOperationClaim {Id = 8, UserId = 1 ,OperationClaimId = 10},
                new UserOperationClaim {Id = 9, UserId = 1 ,OperationClaimId = 11},
                new UserOperationClaim {Id = 10, UserId = 1 ,OperationClaimId = 12},
                new UserOperationClaim {Id = 11, UserId = 1 ,OperationClaimId = 13},
                new UserOperationClaim {Id = 12, UserId = 1 ,OperationClaimId = 14},
                new UserOperationClaim {Id = 13, UserId = 1 ,OperationClaimId = 15},
                new UserOperationClaim {Id = 14, UserId = 1 ,OperationClaimId = 16},
                new UserOperationClaim {Id = 15, UserId = 1 ,OperationClaimId = 17},
                new UserOperationClaim {Id = 16, UserId = 1 ,OperationClaimId = 18},
                new UserOperationClaim {Id = 17, UserId = 1 ,OperationClaimId = 19},
                new UserOperationClaim {Id = 18, UserId = 1 ,OperationClaimId = 20},
                new UserOperationClaim {Id = 19, UserId = 1 ,OperationClaimId = 21},
                new UserOperationClaim {Id = 20, UserId = 1 ,OperationClaimId = 22},
                new UserOperationClaim {Id = 21, UserId = 1 ,OperationClaimId = 23},
                new UserOperationClaim {Id = 22, UserId = 1 ,OperationClaimId = 24},
                new UserOperationClaim {Id = 23, UserId = 1 ,OperationClaimId = 7},
                new UserOperationClaim {Id = 24, UserId = 1 ,OperationClaimId = 8},
                new UserOperationClaim {Id = 25, UserId = 1 ,OperationClaimId = 9}
               
                );
            #endregion

            #region OldRelations
            //modelBuilder.Entity<Car>()
            //    .HasOne(c => c.Brand)
            //    .WithMany()
            //    .HasForeignKey(c => c.BrandId);

            //modelBuilder.Entity<Car>()
            //    .HasOne(c => c.Color)
            //    .WithMany()
            //    .HasForeignKey(c => c.ColorId);

            //modelBuilder.Entity<Customer>()
            //    .HasOne(c => c.User)
            //    .WithMany()
            //    .HasForeignKey(c => c.UserId);

            //modelBuilder.Entity<Rental>()
            //     .HasOne(r => r.Car)
            //     .WithMany()
            //     .HasForeignKey(r => r.CarId);

            //modelBuilder.Entity<Rental>()
            //     .HasOne(r => r.Customer)
            //     .WithMany()
            //     .HasForeignKey(r => r.CustomerId);
            #endregion

            modelBuilder.Entity<Car>()
        .Property(c => c.DailyPrice)
        .HasColumnType("decimal(18, 2)");
        }
    }
}
