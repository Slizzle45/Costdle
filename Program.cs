using Costdle.Data;
using Microsoft.EntityFrameworkCore;

namespace Costdle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            builder.Services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
