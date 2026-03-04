namespace tienda_electrodomesticos.Models
{
    public class MockApplianceRepository : IApplianceRepository
    {
        private static readonly List<Category> _categories = new MockCategoryRepository().AllCategories.ToList();

        public IEnumerable<Appliance> AllAppliances =>
            new List<Appliance>
            {
                // Electrodomésticos (Cat 1)
                new Appliance { ApplianceId = 1, Name = "Refrigerador Premium", Price = 1299.95M, ShortDescription = "Diseño que ahorra espacio", LongDescription = "Un refrigerador altamente eficiente con tecnología de enfriamiento inteligente.", Category = _categories[0], ImageUrl = "/images/fridge_large.png", IsApplianceOfTheWeek = true, InStock = true },
                new Appliance { ApplianceId = 2, Name = "Lavadora Smart", Price = 849.95M, ShortDescription = "Eficiente y silenciosa", LongDescription = "Una lavadora inteligente premium que se conecta a tu smartphone.", Category = _categories[0], ImageUrl = "/images/washer_large.png", IsApplianceOfTheWeek = false, InStock = true },
                new Appliance { ApplianceId = 3, Name = "Secadora Eco", Price = 749.95M, ShortDescription = "Secado de alta eficiencia", LongDescription = "Secadora ahorradora de energía con múltiples programas inteligentes.", Category = _categories[0], ImageUrl = "/images/dryer.png", IsApplianceOfTheWeek = false, InStock = true },
                new Appliance { ApplianceId = 4, Name = "Lavavajillas Compacto", Price = 599.95M, ShortDescription = "Limpieza potente", LongDescription = "Se adapta a cualquier cocina y ofrece limpieza de grado industrial.", Category = _categories[0], ImageUrl = "/images/dishwasher.png", IsApplianceOfTheWeek = true, InStock = true },
                new Appliance { ApplianceId = 5, Name = "Estufa de Gas de Lujo", Price = 1499.00M, ShortDescription = "Cocina nivel chef", LongDescription = "Quemadores de precisión para la mejor experiencia culinaria.", Category = _categories[0], ImageUrl = "/images/stove.png", IsApplianceOfTheWeek = false, InStock = true },

                // Cocina Eléctrica (Cat 2)
                new Appliance { ApplianceId = 6, Name = "Licuadora Digital", Price = 199.95M, ShortDescription = "Licuado de precisión", LongDescription = "Perfecta para batidos y sopas con su motor de alta potencia.", Category = _categories[1], ImageUrl = "/images/blender_large.png", IsApplianceOfTheWeek = true, InStock = true },
                new Appliance { ApplianceId = 7, Name = "Freidora de Aire Smart", Price = 159.00M, ShortDescription = "Fritura saludable", LongDescription = "Fríe con poco o nada de aceite usando tecnología avanzada de aire rápido.", Category = _categories[1], ImageUrl = "/images/airfryer.png", IsApplianceOfTheWeek = false, InStock = true },
                new Appliance { ApplianceId = 8, Name = "Cafetera Espresso Pro", Price = 299.00M, ShortDescription = "Café de calidad barista", LongDescription = "Presión profesional para el espresso perfecto de la mañana.", Category = _categories[1], ImageUrl = "/images/espresso.png", IsApplianceOfTheWeek = true, InStock = true },
                new Appliance { ApplianceId = 9, Name = "Tostadora Digital", Price = 89.00M, ShortDescription = "Tostado perfectamente uniforme", LongDescription = "Múltiples ajustes para un control exacto del dorado.", Category = _categories[1], ImageUrl = "/images/toaster.png", IsApplianceOfTheWeek = false, InStock = true },
                new Appliance { ApplianceId = 10, Name = "Batidora de Mano Plus", Price = 45.00M, ShortDescription = "Mezclado versátil", LongDescription = "Compacta pero potente para todas tus necesidades de repostería.", Category = _categories[1], ImageUrl = "/images/mixer.png", IsApplianceOfTheWeek = false, InStock = true },

                // Tecnología Smart (Cat 3)
                new Appliance { ApplianceId = 11, Name = "Hub de Hogar Inteligente", Price = 129.95M, ShortDescription = "Controla todo", LongDescription = "Hub activado por voz para gestionar todos tus electrodomésticos inteligentes.", Category = _categories[2], ImageUrl = "/images/hub.png", IsApplianceOfTheWeek = false, InStock = true },
                new Appliance { ApplianceId = 12, Name = "Cámara de Seguridad 4K", Price = 199.00M, ShortDescription = "Seguridad cristalina", LongDescription = "Monitorea tu hogar en alta definición desde cualquier lugar.", Category = _categories[2], ImageUrl = "/images/camera.png", IsApplianceOfTheWeek = true, InStock = true },
                new Appliance { ApplianceId = 13, Name = "Cerradura Inteligente", Price = 249.00M, ShortDescription = "Comodidad sin llaves", LongDescription = "Sistema avanzado de bloqueo remoto y biométrico.", Category = _categories[2], ImageUrl = "/images/lock.png", IsApplianceOfTheWeek = false, InStock = true },
                new Appliance { ApplianceId = 14, Name = "Timbre con Video", Price = 179.95M, ShortDescription = "Mira quién está ahí", LongDescription = "Audio bidireccional y alertas de movimiento para tu puerta principal.", Category = _categories[2], ImageUrl = "/images/doorbell.png", IsApplianceOfTheWeek = false, InStock = true },
                new Appliance { ApplianceId = 15, Name = "Kit de Iluminación Smart", Price = 99.00M, ShortDescription = "Colores atmosféricos", LongDescription = "Millones de colores para adaptarse a cualquier estado de ánimo en tu hogar.", Category = _categories[2], ImageUrl = "/images/lights.png", IsApplianceOfTheWeek = false, InStock = true },

                // Clima y Confort (Cat 4)
                new Appliance { ApplianceId = 16, Name = "Purificador de Aire de Torre", Price = 229.00M, ShortDescription = "Aire limpio siempre", LongDescription = "Filtración avanzada para un ambiente hogareño libre de polvo.", Category = _categories[3], ImageUrl = "/images/purifier.png", IsApplianceOfTheWeek = true, InStock = true },
                new Appliance { ApplianceId = 17, Name = "Unidad de AC Smart", Price = 499.00M, ShortDescription = "Enfriamiento inteligente", LongDescription = "Se conecta a tu teléfono para programar ciclos de enfriamiento.", Category = _categories[3], ImageUrl = "/images/ac.png", IsApplianceOfTheWeek = false, InStock = true },
                new Appliance { ApplianceId = 18, Name = "Calefactor Portátil", Price = 79.95M, ShortDescription = "Calor instantáneo", LongDescription = "Elementos de calefacción cerámicos para un calentamiento rápido y seguro.", Category = _categories[3], ImageUrl = "/images/heater.png", IsApplianceOfTheWeek = false, InStock = true },
                new Appliance { ApplianceId = 19, Name = "Deshumidificador Max", Price = 189.00M, ShortDescription = "Control de humedad", LongDescription = "Perfecto para sótanos o climas húmedos.", Category = _categories[3], ImageUrl = "/images/dehumidifier.png", IsApplianceOfTheWeek = false, InStock = true },
                new Appliance { ApplianceId = 20, Name = "Ventilador Inteligente", Price = 119.00M, ShortDescription = "Brisa silenciosa", LongDescription = "Motor ultra silencioso con múltiples ajustes de velocidad.", Category = _categories[3], ImageUrl = "/images/fan.png", IsApplianceOfTheWeek = false, InStock = true }

            };

        public IEnumerable<Appliance> AppliancesOfTheWeek =>
            AllAppliances.Where(p => p.IsApplianceOfTheWeek);

        public Appliance? GetApplianceById(int applianceId) =>
            AllAppliances.FirstOrDefault(p => p.ApplianceId == applianceId);
    }
}
