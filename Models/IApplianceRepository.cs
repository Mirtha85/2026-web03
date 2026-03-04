namespace tienda_electrodomesticos.Models
{
    public interface IApplianceRepository
    {
        IEnumerable<Appliance> AllAppliances { get; }
        IEnumerable<Appliance> AppliancesOfTheWeek { get; }
        Appliance? GetApplianceById(int applianceId);
    }
}
