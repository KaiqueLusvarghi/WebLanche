﻿using Microsoft.AspNetCore.Mvc;
using WebLanches.Areas.Admin.Services;

namespace WebLanches.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminRelatorioVendasController : Controller
    {
        private readonly RelatorioVendasService relatorioVendasService;

        public AdminRelatorioVendasController(RelatorioVendasService relatorioVendasService)
        {
            this.relatorioVendasService = relatorioVendasService;
        }

        public IActionResult Index()
        {
            return View();
        }
    
        public async Task<IActionResult> RelatorioVendasSimples(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year,1,1);
            }

            if (!maxDate.HasValue)
            {
                maxDate = new DateTime(DateTime.Now.Year, 1, 1);
            }

            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");

            var result = await relatorioVendasService.FindByDateAsync(minDate,maxDate);
            return View(result);
        }
    }
}
