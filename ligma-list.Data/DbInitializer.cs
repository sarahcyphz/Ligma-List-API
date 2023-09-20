using ligma_list.Domain.catalog;
using Microsoft.EntityFrameworkCore;

namespace ligma_list.Data
{
    public static class DbIntializer
    {
        public static void Intialize(ModelBuilder builder)
        {
            builder.Entity<Item>().HasData(
                new Item("Tajin") { Id = 1 },
                new Item("Chili Powder") { Id = 2 }
            );
        }
    }
}