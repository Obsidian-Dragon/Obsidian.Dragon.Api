using Obsidian.Dragon.Domain.Catalog;
using Microsoft.EntityFrameworkCore;
using Obsidian.Dragon.Domain.Orders;

namespace Obsidian.Dragon.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        { }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; } 
        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            DBInitializer.Initialize(builder);
        }
    }
}
