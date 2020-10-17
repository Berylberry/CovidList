using Microsoft.EntityFrameworkCore;
using backend_netcore.Entities;

namespace backend_netcore.Helpers
{
    public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { }

    
    public DbSet<User> Users {get; set;}
    public DbSet<Attendance> Attendance {get; set;}
    public DbSet<Church> Churches {get; set;}
    public DbSet<Event> Events {get; set;}
    public DbSet<Location> Locations {get; set;}
    public DbSet<Member> Members {get; set;}
  }
}