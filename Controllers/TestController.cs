using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tienda_electrodomesticos.Models;
using tienda_electrodomesticos.ViewModels;

namespace tienda_electrodomesticos.Controllers
{
    public class TestController : Controller
    {
        private readonly TiendaElectrodomesticosDbContext _db;

        public TestController(TiendaElectrodomesticosDbContext db)
        {
            _db = db;
        }

        public IActionResult List()
        {
            ViewBag.Message = "Proyección de Categorías e Inclusión de Productos (Pattern: One-to-Many)";
           //relacion uno a muchos
            var result = _db.Categories
                .Include(c => c.Appliances)  // Aquí ocurre el JOIN internamente 
                .Select(c => new CategoryAppliancesViewModel
                {
                    CategoryName = c.CategoryName,
                    Appliances = c.Appliances ?? new List<Appliance>()
                })
                .ToList();

            /* 
             * EJEMPLOS DE OTROS TIPOS DE RELACIONES:
             *
             * 1. RELACIÓN UNO A UNO (One-to-One)
             * Ejemplo: Un Estudiante tiene un solo Expediente.
             * 
             * var result = _db.Students
             *     .Include(s => s.StudentProfile) // JOIN con la tabla de perfil único
             *     .Select(s => new {
             *         s.Name,
             *         Bio = s.StudentProfile.Bio // Acceso directo al objeto único
             *     })
             *     .ToList();
             *
             * 2. RELACIÓN MUCHOS A MUCHOS (Many-to-Many)
             * Ejemplo: Estudiantes y Cursos (Un estudiante tiene muchos cursos, un curso tiene muchos estudiantes).
             * En EF Core 5.0+ la tabla intermedia se puede manejar automáticamente.
             * 
             * var result = _db.Students
             *     .Include(s => s.Courses) // El JOIN pasa por la tabla intermedia internamente
             *     .Select(s => new {
             *         StudentName = s.Name,
             *         CourseTitles = s.Courses.Select(c => c.Title) // Proyectamos la lista de cursos
             *     })
             *     .ToList();
             *
             * 3. CARGA FILTRADA (Filtered Include)
             * Solo traer los "Muchos" que cumplan una condición.
             * 
             * var result = _db.Categories
             *     .Include(c => c.Appliances.Where(a => a.InStock)) // Solo appliances con stock
             *     .ToList();
             */

            return View(result);
        }
    }
}
