using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repository.Interface;
using LanchesMac.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LanchesMac.Controllers
{
    public class HomeController : Controller
    {
         protected readonly ILancheRepository _lancheRepository;

        public HomeController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                LanchesPreferidos = _lancheRepository.LanchesPreferidos
            };

            return View(homeViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
