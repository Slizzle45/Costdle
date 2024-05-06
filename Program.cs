using Costdle.Models;
using Microsoft.EntityFrameworkCore;

namespace Costdle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            builder.Services.AddDbContext<DataContext>();

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
