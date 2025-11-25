using Langgo.Application;
using Langgo.Application.Services;
using Langgo.Infrastructure;
using Microsoft.OpenApi.Models;

namespace Langgo.API;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        {
            builder.Services.AddApplication();
            builder.Services.AddInfrastructure(builder.Configuration);

            // Зарегистрировать контроллеры и Swagger для разработки
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Langgo API", Version = "v1" });
            });

            // Простая CORS политика для локальной разработки
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowLocal", policy =>
                {
                    policy.AllowAnyOrigin()
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                });
            });
        }
        
        var app = builder.Build();

        // Dev tools
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        
        app.UseHttpsRedirection();
        app.UseCors("AllowLocal");

        app.MapControllers();
        
        app.Run();
    }
}