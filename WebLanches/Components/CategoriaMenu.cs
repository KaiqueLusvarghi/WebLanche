using Microsoft.AspNetCore.Mvc;
using WebLanches.Repositories.Interfaces;

namespace WebLanches.Components
{
    public class CategoriaMenu : ViewComponent
    {
        private readonly ICategoriaRepository _categoriaRepository;
        public CategoriaMenu (ICategoriaRepository CategoriaRepository)
        {
            _categoriaRepository = CategoriaRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categoria = _categoriaRepository.Categorias.OrderBy(c => c.CategoriaNome);
            return View(categoria);
        }
    }
}
