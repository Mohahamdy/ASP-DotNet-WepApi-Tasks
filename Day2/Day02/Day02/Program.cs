
using Day02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Day02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string txt = "";

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(
                o =>
                {
                    o.SwaggerDoc("v1", new OpenApiInfo()
                    {
                        Title = "API ITI-Data",
                        Version = "v1",
                        Description = "API To manage The ITI Data",
                        Contact = new OpenApiContact
                        {
                            Name = "Hamdy",
                            Email = "mohahamdy11@gmail.com"
                        },
                    });
                    o.IncludeXmlComments(Path.Combine(System.AppContext.BaseDirectory, "ApiDocumentation.xml"));
                    o.EnableAnnotations();
                });

            builder.Services.AddDbContext<ITIContext>(o=> o.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("ITIConn")));

            builder.Services.AddCors(o =>
                    {
                        o.AddPolicy(txt, 
                        builder =>
                        {
                            builder.AllowAnyOrigin();
                            builder.AllowAnyMethod();
                            builder.AllowAnyHeader();
                        });
                    }
                );

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors(txt);

            app.MapControllers();

            app.Run();
        }
    }
}
