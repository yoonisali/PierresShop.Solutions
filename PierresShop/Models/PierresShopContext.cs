// Needed for accessing database

using Microsoft.EntityFrameworkCore;


namespace PierresShop.Models 
{
  public class PierresShopContext : DbContext 
  {
    
    public PierresShopContext(DbContextOptions options) : base(options) { } 
  }
}