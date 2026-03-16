using tienda_electrodomesticos.Models;

namespace tienda_electrodomesticos.Models
{
    public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            TiendaElectrodomesticosDbContext context = applicationBuilder.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<TiendaElectrodomesticosDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Appliances.Any())
            {
                context.AddRange
                (
                    new Appliance { Name = "Refrigerador Premium", Price = 1299.95M, ShortDescription = "Diseño que ahorra espacio", LongDescription = "Un refrigerador altamente eficiente con tecnología de enfriamiento inteligente.", Category = Categories["Electrodomésticos"], ImageUrl = "/images/fridge_large.png", IsApplianceOfTheWeek = true, InStock = true },
                    new Appliance { Name = "Lavadora Smart", Price = 849.95M, ShortDescription = "Eficiente y silenciosa", LongDescription = "Una lavadora inteligente premium que se conecta a tu smartphone.", Category = Categories["Electrodomésticos"], ImageUrl = "/images/washer_large.png", IsApplianceOfTheWeek = false, InStock = true },
                    new Appliance { Name = "Secadora Eco", Price = 749.95M, ShortDescription = "Secado de alta eficiencia", LongDescription = "Secadora ahorradora de energía con múltiples programas inteligentes.", Category = Categories["Electrodomésticos"], ImageUrl = "/images/dryer.png", IsApplianceOfTheWeek = false, InStock = true },
                    new Appliance { Name = "Lavavajillas Compacto", Price = 599.95M, ShortDescription = "Limpieza potente", LongDescription = "Se adapta a cualquier cocina y ofrece limpieza de grado industrial.", Category = Categories["Electrodomésticos"], ImageUrl = "/images/dishwasher.png", IsApplianceOfTheWeek = true, InStock = true },
                    new Appliance { Name = "Estufa de Gas de Lujo", Price = 1499.00M, ShortDescription = "Cocina nivel chef", LongDescription = "Quemadores de precisión para la mejor experiencia culinaria.", Category = Categories["Electrodomésticos"], ImageUrl = "/images/stove.png", IsApplianceOfTheWeek = false, InStock = true },
                    new Appliance { Name = "Licuadora Digital", Price = 199.95M, ShortDescription = "Licuado de precisión", LongDescription = "Perfecta para batidos y sopas con su motor de alta potencia.", Category = Categories["Cocina Eléctrica"], ImageUrl = "/images/blender_large.png", IsApplianceOfTheWeek = true, InStock = true },
                    new Appliance { Name = "Freidora de Aire Smart", Price = 159.00M, ShortDescription = "Fritura saludable", LongDescription = "Fríe con poco o nada de aceite usando tecnología avanzada de aire rápido.", Category = Categories["Cocina Eléctrica"], ImageUrl = "/images/airfryer.png", IsApplianceOfTheWeek = false, InStock = true },
                    new Appliance { Name = "Cafetera Espresso Pro", Price = 299.00M, ShortDescription = "Café de calidad barista", LongDescription = "Presión profesional para el espresso perfecto de la mañana.", Category = Categories["Cocina Eléctrica"], ImageUrl = "/images/espresso.png", IsApplianceOfTheWeek = true, InStock = true },
                    new Appliance { Name = "Tostadora Digital", Price = 89.00M, ShortDescription = "Tostado perfectamente uniforme", LongDescription = "Múltiples ajustes para un control exacto del dorado.", Category = Categories["Cocina Eléctrica"], ImageUrl = "/images/toaster.png", IsApplianceOfTheWeek = false, InStock = true },
                    new Appliance { Name = "Batidora de Mano Plus", Price = 45.00M, ShortDescription = "Mezclado versátil", LongDescription = "Compacta pero potente para todas tus necesidades de repostería.", Category = Categories["Cocina Eléctrica"], ImageUrl = "/images/mixer.png", IsApplianceOfTheWeek = false, InStock = true },
                    new Appliance { Name = "Hub de Hogar Inteligente", Price = 129.95M, ShortDescription = "Controla todo", LongDescription = "Hub activado por voz para gestionar todos tus electrodomésticos inteligentes.", Category = Categories["Tecnología Smart"], ImageUrl = "/images/hub.png", IsApplianceOfTheWeek = false, InStock = true },
                    new Appliance { Name = "Cámara de Seguridad 4K", Price = 199.00M, ShortDescription = "Seguridad cristalina", LongDescription = "Monitorea tu hogar en alta definición desde cualquier lugar.", Category = Categories["Tecnología Smart"], ImageUrl = "/images/camera.png", IsApplianceOfTheWeek = true, InStock = true },
                    new Appliance { Name = "Cerradura Inteligente", Price = 249.00M, ShortDescription = "Comodidad sin llaves", LongDescription = "Sistema avanzado de bloqueo remoto y biométrico.", Category = Categories["Tecnología Smart"], ImageUrl = "/images/lock.png", IsApplianceOfTheWeek = false, InStock = true },
                    new Appliance { Name = "Timbre con Video", Price = 179.95M, ShortDescription = "Mira quién está ahí", LongDescription = "Audio bidireccional y alertas de movimiento para tu puerta principal.", Category = Categories["Tecnología Smart"], ImageUrl = "/images/doorbell.png", IsApplianceOfTheWeek = false, InStock = true },
                    new Appliance { Name = "Kit de Iluminación Smart", Price = 99.00M, ShortDescription = "Colores atmosféricos", LongDescription = "Millones de colores para adaptarse a cualquier estado de ánimo en tu hogar.", Category = Categories["Tecnología Smart"], ImageUrl = "/images/lights.png", IsApplianceOfTheWeek = false, InStock = true },
                    new Appliance { Name = "Purificador de Aire de Torre", Price = 229.00M, ShortDescription = "Aire limpio siempre", LongDescription = "Filtración avanzada para un ambiente hogareño libre de polvo.", Category = Categories["Clima y Confort"], ImageUrl = "/images/purifier.png", IsApplianceOfTheWeek = true, InStock = true },
                    new Appliance { Name = "Unidad de AC Smart", Price = 499.00M, ShortDescription = "Enfriamiento inteligente", LongDescription = "Se conecta a tu teléfono para programar ciclos de enfriamiento.", Category = Categories["Clima y Confort"], ImageUrl = "/images/ac.png", IsApplianceOfTheWeek = false, InStock = true },
                    new Appliance { Name = "Calefactor Portátil", Price = 79.95M, ShortDescription = "Calor instantáneo", LongDescription = "Elementos de calefacción cerámicos para un calentamiento rápido y seguro.", Category = Categories["Clima y Confort"], ImageUrl = "/images/heater.png", IsApplianceOfTheWeek = false, InStock = true },
                    new Appliance { Name = "Deshumidificador Max", Price = 189.00M, ShortDescription = "Control de humedad", LongDescription = "Perfecto para sótanos o climas húmedos.", Category = Categories["Clima y Confort"], ImageUrl = "/images/dehumidifier.png", IsApplianceOfTheWeek = false, InStock = true },
                    new Appliance { Name = "Ventilador Inteligente", Price = 119.00M, ShortDescription = "Brisa silenciosa", LongDescription = "Motor ultra silencioso con múltiples ajustes de velocidad.", Category = Categories["Clima y Confort"], ImageUrl = "/images/fan.png", IsApplianceOfTheWeek = false, InStock = true }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category>? _categories;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (_categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Electrodomésticos", Description = "Refrigeradores, Lavadoras, Secadoras" },
                        new Category { CategoryName = "Cocina Eléctrica", Description = "Microondas, Licuadoras, Tostadoras" },
                        new Category { CategoryName = "Tecnología Smart", Description = "Pantallas inteligentes, Cámaras de seguridad" },
                        new Category { CategoryName = "Clima y Confort", Description = "Aires Acondicionados, Ventiladores, Calefactores" }
                    };

                    _categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        _categories.Add(genre.CategoryName, genre);
                    }
                }

                return _categories;
            }
        }
    }
}
