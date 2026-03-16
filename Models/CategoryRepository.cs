namespace tienda_electrodomesticos.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly TiendaElectrodomesticosDbContext _tiendaElectrodomesticosDbContext;

        public CategoryRepository(TiendaElectrodomesticosDbContext tiendaElectrodomesticosDbContext)
        {
            _tiendaElectrodomesticosDbContext = tiendaElectrodomesticosDbContext;
        }

        public IEnumerable<Category> AllCategories => _tiendaElectrodomesticosDbContext.Categories.OrderBy(p => p.CategoryName);
    }
}
