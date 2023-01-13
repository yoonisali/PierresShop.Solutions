using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace PierresShop.Models 
{
  public class PierresShopContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Treat> Treats { get; set; } 
    public DbSet<Flavor> Flavors { get; set; } 
    public DbSet<TreatFlavor> TreatFlavors { get; set; } 
    public PierresShopContext(DbContextOptions options) : base(options) { } 
  }
}