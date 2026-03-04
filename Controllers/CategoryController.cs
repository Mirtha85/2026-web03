using Microsoft.AspNetCore.Mvc;
using tienda_electrodomesticos.Models;
using tienda_electrodomesticos.ViewModels;

namespace tienda_electrodomesticos.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            return View(_categoryRepository.AllCategories);
        }
    }
}
