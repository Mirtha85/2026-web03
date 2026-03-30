namespace tienda_electrodomesticos.Models
{
    public interface IShoppingCart
    {
        void AddToCart(Appliance appliance);
        int RemoveFromCart(Appliance appliance);
        List<ShoppingCartItem> GetShoppingCartItems();
        void ClearCart();
        decimal GetShoppingCartTotal();
        List<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
