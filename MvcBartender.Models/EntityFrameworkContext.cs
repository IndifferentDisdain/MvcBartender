using System.Data.Entity;

namespace MvcBartender.Models
{
    public class EntityFrameworkContext : DbContext
    {
        public EntityFrameworkContext() : base("MvcBartender") { }

        public DbSet<Drink> Drinks { get; set; }

        public DbSet<DrinkOrder> DrinkOrders { get; set; }

        public DbSet<DrinkOrderItem> DrinkOrderItems { get; set; }
    }
}
