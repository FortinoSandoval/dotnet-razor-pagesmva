using Microsoft.EntityFrameworkCore;

namespace razorPagesApp
{
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Customer> Customers { get; set; }
  }
}