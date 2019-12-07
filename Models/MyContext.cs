using Microsoft.EntityFrameworkCore;
using wedding_planner.Models;
namespace wedding_planner.Models
{
  public class MyContext : DbContext
  {
    // base() calls the parent class' constructor passing the "options" parameter along
    public MyContext(DbContextOptions options) : base(options) { }

    // "users" table is represented by this DbSet "Users"
    public DbSet<User> Users { get; set; }
    public DbSet<Wedding> Weddings { get; set; }
    public DbSet<UserWedding> UsersWeddings { get; set; }
  }
}