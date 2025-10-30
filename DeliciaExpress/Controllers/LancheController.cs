using Microsoft.AspNetCore.Mvc;
using DeliciaExpress.Repository.Interfaces;

namespace DeliciaExpress.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILanchesRepository _lancheRepository;

        public LancheController(ILanchesRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
            var lanches = _lancheRepository.lanches;
            return View(lanches);
        }
    }
}
