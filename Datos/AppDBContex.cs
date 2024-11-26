using Microsoft.EntityFrameworkCore;
using TerraMarketPlace.API.Models;

namespace TerraMarketPlace.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
