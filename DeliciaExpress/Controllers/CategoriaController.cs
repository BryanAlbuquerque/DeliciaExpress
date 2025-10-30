using DeliciaExpress.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DeliciaExpress.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaController(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }
        public IActionResult List()
        {
            var categoria = _categoriaRepository.Categorias;
            return View(categoria);
        }
    }
}
