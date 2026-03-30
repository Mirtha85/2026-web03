using Microsoft.AspNetCore.Mvc;
using tienda_electrodomesticos.Models;
using tienda_electrodomesticos.ViewModels;

namespace tienda_electrodomesticos.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IApplianceRepository _applianceRepository;
        private readonly IShoppingCart _shoppingCart;

        public ShoppingCartController(IApplianceRepository applianceRepository, IShoppingCart shoppingCart)
        {
            _applianceRepository = applianceRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel(_shoppingCart, _shoppingCart.GetShoppingCartTotal());

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int applianceId)
        {
            var selectedAppliance = _applianceRepository.AllAppliances.FirstOrDefault(p => p.ApplianceId == applianceId);

            if (selectedAppliance != null)
            {
                _shoppingCart.AddToCart(selectedAppliance);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int applianceId)
        {
            var selectedAppliance = _applianceRepository.AllAppliances.FirstOrDefault(p => p.ApplianceId == applianceId);

            if (selectedAppliance != null)
            {
                _shoppingCart.RemoveFromCart(selectedAppliance);
            }
            return RedirectToAction("Index");
        }
    }
}
