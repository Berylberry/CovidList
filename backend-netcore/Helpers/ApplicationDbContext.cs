using Microsoft.EntityFrameworkCore;
using backend_netcore.Entities;

namespace backend_netcore.Helpers
{
    public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { }

    
    public DbSet<User> User {get; set;}
    public DbSet<Attendance> Attendance {get; set;}
    public DbSet<Church> Church {get; set;}
    public DbSet<Event> Event {get; set;}
    public DbSet<Location> Location {get; set;}
    public DbSet<Member> Member {get; set;}
  }
}