using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebLanches.Models;

namespace WebLanches.Controllers
{
    public class HomeController : Controller
    {
    
        public IActionResult Index()
        {
            TempData["Nome"] = "Lusvarghi"; 
            return View();
        }

        public IActionResult Demo()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
