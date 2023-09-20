using ligma_list.Domain.catalog;
using Microsoft.EntityFrameworkCore;

namespace ligma_list.Data
{
    public class SpiceContext : DbContext
    {
        public SpiceContext(DbContextOptions<SpiceContext> options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            DbIntializer.Intialize(builder);
        }
    }
}
