using Microsoft.AspNetCore.Mvc;
using tienda_electrodomesticos.Models;
using tienda_electrodomesticos.ViewModels;

namespace tienda_electrodomesticos.Controllers
{
    public class ApplianceController : Controller
    {
        private readonly IApplianceRepository _applianceRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ApplianceController(IApplianceRepository applianceRepository, ICategoryRepository categoryRepository)
        {
            _applianceRepository = applianceRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            ApplianceListViewModel applianceListViewModel = new ApplianceListViewModel(_applianceRepository.AllAppliances, "Electrodomésticos Destacados");
            return View(applianceListViewModel);
        }

        public IActionResult Details(int id)
        {
            var appliance = _applianceRepository.GetApplianceById(id);
            if (appliance == null)
                return NotFound();

            return View(appliance);
        }
    }
}
