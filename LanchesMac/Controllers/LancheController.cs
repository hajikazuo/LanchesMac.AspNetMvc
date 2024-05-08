using LanchesMac.Repository.Interface;
using LanchesMac.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
            var lanches = new LancheListViewModel();
            lanches.Lanches = _lancheRepository.Lanches;
            lanches.CategoriaAtual = "Categoria Atual";
            return View(lanches);   
        }
    }
}
