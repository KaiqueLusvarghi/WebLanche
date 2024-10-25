using Microsoft.AspNetCore.Mvc;
using WebLanches.Models;
using WebLanches.Repositories.Interfaces;

namespace WebLanches.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IPedidoRepository _PedidoRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public PedidoController(IPedidoRepository pedidoRepository, CarrinhoCompra carrinhoCompra)
        {
            _PedidoRepository = pedidoRepository;
            _carrinhoCompra = carrinhoCompra;
        }
        [HttpGet]
        public IActionResult Checkout()
        { 
            return View();
        }
        [HttpPost]
        public IActionResult Checkout(Pedido pedido) 
        {
            return View();
        }
    }
}
