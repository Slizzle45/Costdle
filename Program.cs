using Costdle.Models;
using Microsoft.EntityFrameworkCore;

namespace Costdle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            

            var builder = WebApplication.CreateBuilder(args);
            //
            builder.Services.AddDbContext<DataContext>();//Connection string on appsettings.json
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            //
            var app = builder.Build();


            

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
