using tienda_electrodomesticos.Models;

namespace tienda_electrodomesticos.ViewModels
{
    public class ApplianceListViewModel
    {
        public IEnumerable<Appliance> Appliances { get; }
        public string? CurrentCategory { get; }

        public ApplianceListViewModel(IEnumerable<Appliance> appliances, string? currentCategory)
        {
            Appliances = appliances;
            CurrentCategory = currentCategory;
        }
    }
}
