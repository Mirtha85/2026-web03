using Microsoft.EntityFrameworkCore;

namespace tienda_electrodomesticos.Models
{
    public class ApplianceRepository : IApplianceRepository
    {
        private readonly TiendaElectrodomesticosDbContext _tiendaElectrodomesticosDbContext;

        public ApplianceRepository(TiendaElectrodomesticosDbContext tiendaElectrodomesticosDbContext)
        {
            _tiendaElectrodomesticosDbContext = tiendaElectrodomesticosDbContext;
        }

        public IEnumerable<Appliance> AllAppliances
        {
            get
            {
                return _tiendaElectrodomesticosDbContext.Appliances.Include(c => c.Category);
            }
        }

        public IEnumerable<Appliance> AppliancesOfTheWeek
        {
            get
            {
                return _tiendaElectrodomesticosDbContext.Appliances.Include(c => c.Category).Where(p => p.IsApplianceOfTheWeek);
            }
        }

        public Appliance? GetApplianceById(int applianceId)
        {
            return _tiendaElectrodomesticosDbContext.Appliances.FirstOrDefault(p => p.ApplianceId == applianceId);
        }
    }
}
