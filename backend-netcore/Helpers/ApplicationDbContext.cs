using Microsoft.EntityFrameworkCore;

namespace backend_netcore.Helpers
{
    public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { }

    // public DbSet<FoodRecord> FoodRecords { get; set; }
  }
}