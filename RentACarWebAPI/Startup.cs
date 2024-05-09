using Core.DependencyResolvers;
using Core.Extensions;
using Core.Utilities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;

namespace WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //AOP
            //Autofac, Ninject,CastleWindsor, StructureMap, LightInject, DryInject -->IoC Container
            //AOP
            //Postsharp
            services.AddControllers();

            services.AddCors();

            var tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidIssuer = tokenOptions.Issuer,
                        ValidAudience = tokenOptions.Audience,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey),
                    };
                });

            services.AddDependencyResolvers(new ICoreModule[]
            {
                new CoreModule()
            });

            services.AddSwaggerGen(c =>
             {
                 c.SwaggerDoc("v1",
                     new Microsoft.OpenApi.Models.OpenApiInfo
                     {
                         Title = "Kahveci RentACar",
                         Version = "v1"
                     });
                 var filename = Assembly.GetExecutingAssembly().GetName().Name + ".xml";
                 var filepath = Path.Combine(AppContext.BaseDirectory, filename);
                 c.IncludeXmlComments(filepath);

                 var securityScheme = new OpenApiSecurityScheme
                 {
                     Name = "Authorization",
                     Description = "JWT Authorization header using the Bearer scheme.",
                     Type = SecuritySchemeType.Http,
                     Scheme = "bearer",
                     BearerFormat = "JWT"
                 };
                 c.AddSecurityDefinition("Bearer", securityScheme);

                 var securityRequirement = new OpenApiSecurityRequirement
                 {
                     {
                         new OpenApiSecurityScheme
                         {
                             Reference = new OpenApiReference
                             {
                                 Type = ReferenceType.SecurityScheme,
                                 Id = "Bearer"
                             }
                         },
                         new string[]{ }
                     }
                 };
                 c.AddSecurityRequirement(securityRequirement);
             });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(builder => builder.WithOrigins("http://localhost:4200").AllowAnyHeader());

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger");
            });

        }
    }
}