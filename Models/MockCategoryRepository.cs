namespace tienda_electrodomesticos.Models
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category { CategoryId = 1, CategoryName = "Electrodomésticos", Description = "Refrigeradores, Lavadoras, Secadoras" },
                new Category { CategoryId = 2, CategoryName = "Cocina Eléctrica", Description = "Microondas, Licuadoras, Tostadoras" },
                new Category { CategoryId = 3, CategoryName = "Tecnología Smart", Description = "Pantallas inteligentes, Cámaras de seguridad" },
                new Category { CategoryId = 4, CategoryName = "Clima y Confort", Description = "Aires Acondicionados, Ventiladores, Calefactores" }
            };
    }
}
