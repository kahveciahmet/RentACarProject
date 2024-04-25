
using Business;
using DataAccess;
using System.Reflection;

namespace RentACarWebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddSingleton<IBrandService, BrandManager>();
            builder.Services.AddSingleton<IBrandDal, EfBrandDal>();
            builder.Services.AddSingleton<IColorService, ColorManager>();
            builder.Services.AddSingleton<IColorDal, EfColorDal>();
            builder.Services.AddSingleton<IUserService, UserManager>();
            builder.Services.AddSingleton<IUserDal, EfUserDal>();
            builder.Services.AddSingleton<IRentalService, RentalManager>();
            builder.Services.AddSingleton<IRentalDal, EfRentalDal>();
            builder.Services.AddSingleton<IUserService, UserManager>();
            builder.Services.AddSingleton<IUserDal, EfUserDal>();
            builder.Services.AddSingleton<ICustomerService, CustomerManager>();
            builder.Services.AddSingleton<ICustomerDal, EfCustomerDal>();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(Options =>
            {
                Options.SwaggerDoc("v1",
                    new Microsoft.OpenApi.Models.OpenApiInfo
                    {
                        Title = "Kahveci RentACar",
                        Version = "v1"
                    });
                var filename = Assembly.GetExecutingAssembly().GetName().Name + ".xml";
                var filepath = Path.Combine(AppContext.BaseDirectory, filename);
                Options.IncludeXmlComments(filepath);
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
