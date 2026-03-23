using tienda_electrodomesticos.Models;

namespace tienda_electrodomesticos.ViewModels
{
    public class CategoryAppliancesViewModel
    {
        public string CategoryName { get; set; } = string.Empty;
        public IEnumerable<Appliance> Appliances { get; set; } = new List<Appliance>();
    }
}
