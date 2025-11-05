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
            //var lanches = _lancheRepository.lanches;
            //return View(lanches);

            var LanchesViewModel = new ViewModels.LanchesListViewModel();
            LanchesViewModel.Lanches = _lancheRepository.lanches;
            LanchesViewModel.CategoriaAtual = "Categoria Atual";
            return View(LanchesViewModel);
        }
    }
}
