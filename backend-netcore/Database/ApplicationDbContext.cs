using Microsoft.EntityFrameworkCore;

namespace backend_netcore.Database
{
    public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { }

    // public DbSet<FoodRecord> FoodRecords { get; set; }
  }
}