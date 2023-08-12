using ContentApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ContentApp.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Inventory>()
                .HasOne(inv => inv.Account)
                .WithMany(acc => acc.Inventories)
                .HasForeignKey(inv => inv.AccountId);

            modelBuilder.Entity<Product>()
                .HasOne(prod => prod.Inventory)
                .WithMany(inv => inv.Products)
                .HasForeignKey(prod => prod.InventoryId);
        }
    }
}
