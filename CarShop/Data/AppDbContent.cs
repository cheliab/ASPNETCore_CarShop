using CarShop.Models;
using Microsoft.EntityFrameworkCore;

namespace CarShop.Data
{
    public class AppDbContent : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public DbSet<Category> Categories { get; set; }
            
        public AppDbContent(DbContextOptions<AppDbContent> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}