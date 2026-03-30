using Microsoft.EntityFrameworkCore;

namespace tienda_electrodomesticos.Models
{
    public class ShoppingCart : IShoppingCart
    {
        private readonly TiendaElectrodomesticosDbContext _tiendaElectrodomesticosDbContext;

        public string? ShoppingCartId { get; set; }

        public List<ShoppingCartItem> ShoppingCartItems { get; set; } = default!;

        private ShoppingCart(TiendaElectrodomesticosDbContext tiendaElectrodomesticosDbContext)
        {
            _tiendaElectrodomesticosDbContext = tiendaElectrodomesticosDbContext;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession? session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext?.Session;

            TiendaElectrodomesticosDbContext context = services.GetService<TiendaElectrodomesticosDbContext>() ?? throw new Exception("Error initializing");

            string cartId = session?.GetString("CartId") ?? Guid.NewGuid().ToString();

            session?.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Appliance appliance)
        {
            var shoppingCartItem =
                    _tiendaElectrodomesticosDbContext.ShoppingCartItems.SingleOrDefault(
                        s => s.Appliance.ApplianceId == appliance.ApplianceId && s.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Appliance = appliance,
                    Amount = 1
                };

                _tiendaElectrodomesticosDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _tiendaElectrodomesticosDbContext.SaveChanges();
        }

        public int RemoveFromCart(Appliance appliance)
        {
            var shoppingCartItem =
                    _tiendaElectrodomesticosDbContext.ShoppingCartItems.SingleOrDefault(
                        s => s.Appliance.ApplianceId == appliance.ApplianceId && s.ShoppingCartId == ShoppingCartId);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _tiendaElectrodomesticosDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _tiendaElectrodomesticosDbContext.SaveChanges();

            return localAmount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??=
                       _tiendaElectrodomesticosDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                           .Include(s => s.Appliance)
                           .ToList();
        }

        public void ClearCart()
        {
            var cartItems = _tiendaElectrodomesticosDbContext
                .ShoppingCartItems
                .Where(cart => cart.ShoppingCartId == ShoppingCartId);

            _tiendaElectrodomesticosDbContext.ShoppingCartItems.RemoveRange(cartItems);

            _tiendaElectrodomesticosDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _tiendaElectrodomesticosDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.Appliance.Price * c.Amount).Sum();
            return total;
        }
    }
}
