using Microsoft.AspNetCore.Mvc;

namespace WebLanches.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
