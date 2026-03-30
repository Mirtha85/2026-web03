using Microsoft.EntityFrameworkCore;

namespace tienda_electrodomesticos.Models
{
    public class TiendaElectrodomesticosDbContext : DbContext
    {
        public TiendaElectrodomesticosDbContext(DbContextOptions<TiendaElectrodomesticosDbContext> options) : base(options)
        {
        }

        public DbSet<Appliance> Appliances { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

    }
}
