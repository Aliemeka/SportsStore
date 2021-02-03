using System.Data.Entity;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Data
{
    public class StoreDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
