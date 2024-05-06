using Microsoft.EntityFrameworkCore;

namespace Costdle.Models
{
    public class DataContext : DbContext
    {
        //public DataContext(DbContextOptions<DataContext> options) : base(options)
        //{

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("DefaultConnection");//appsettings.json
        }

        public DbSet<Product> Products { get; set; }

    }
}
