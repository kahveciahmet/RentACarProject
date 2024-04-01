using Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DataAccess
{
    public class RentACarContextDB : DbContext
    {
        private const string ConnectionString = $"data source={StaticData.SQLServerName};initial catalog={StaticData.DBName};persist security info=True;Integrated Security=SSPI;MultipleActiveResultSets=True;App=EntityFramework&quot;TrustServerCertificate=True;\";\r\n";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var type in Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.BaseType != null && t.BaseType.IsGenericType &&
                    t.BaseType.GetGenericTypeDefinition() == typeof(BaseConfig<>)))
            {
                modelBuilder.ApplyConfiguration((dynamic)Activator.CreateInstance(type));
            }

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}
