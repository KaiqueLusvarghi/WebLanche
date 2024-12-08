using Microsoft.AspNetCore.Mvc;
using WebLanches.Areas.Admin.Services;

namespace WebLanches.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminGraficoController : Controller
    {
        private readonly GraficoVendasServices _graficoVendas;

        public AdminGraficoController(GraficoVendasServices graficoVendas)
        {
            _graficoVendas = graficoVendas ??  throw
                new ArgumentException(nameof(graficoVendas));
        }

        public JsonResult VendasLanches (int dias)
        {
            var lanchesVendasTotais = _graficoVendas.GetVendasLanche(dias);
            return Json(lanchesVendasTotais);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult VendasMensal()
        {
            return View();
        }

        [HttpGet]
        public IActionResult VendasSemanal()
        {
            return View();
        }
    }
}
