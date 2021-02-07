using Coffee_Shop.DALModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Coffee_Shop.Services
{
    public class ShopContext : IdentityDbContext
    {
        public ShopContext(DbContextOptions options) : base(options)
        {

        }

        // DBSets represents your table in your DB
        public DbSet<FundsDAL> Funds { get; set; }

        public DbSet<ItemsDAL> Items { get; set; }
    }
}
