using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
namespace Week5Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        app.UseSwagger();
        app.UseSwaggerUI();


        if (app.Environment.IsDevelopment())
        {
            app.UseHttpsRedirection();
        }

        app.MapGet("/", () => "Week5Api is running. Try /swagger or /hello");

        app.UseAuthorization();

        

        app.MapControllers();

        app.Run();
    }
}


    