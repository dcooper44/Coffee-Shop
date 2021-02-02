using Coffee_Shop.DALModels;
using Microsoft.EntityFrameworkCore;


namespace Coffee_Shop.Services
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions options) : base(options)
        {

        }

        // DBSets represents your table in your DB
        public DbSet<UserDAL> Users { get; set; }

        public DbSet<ItemsDAL> Items { get; set; }
    }
}
