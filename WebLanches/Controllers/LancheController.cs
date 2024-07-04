using Microsoft.AspNetCore.Mvc;
using WebLanches.Repositories.Interfaces;

namespace WebLanches.Controllers
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
            ViewData["Titulo"] = "Todos os lanches";
            ViewData["Data"] = DateTime.Now;

            var lanches = _lancheRepository.Lanches;
            var totalLanches = lanches.Count();

            ViewBag.Total = "Total De Lanches";
            ViewBag.TotalLanches = totalLanches; ;

            return View(lanches);
        }
    }
}
